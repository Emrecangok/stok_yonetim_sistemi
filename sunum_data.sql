PGDMP      '                |            stok_yonetim_data    14.13    16.4 N    R           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            S           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            T           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            U           1262    74476    stok_yonetim_data    DATABASE     �   CREATE DATABASE stok_yonetim_data WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_T�rkiye.1254';
 !   DROP DATABASE stok_yonetim_data;
                postgres    false                        2615    2200    public    SCHEMA     2   -- *not* creating schema, since initdb creates it
 2   -- *not* dropping schema, since initdb creates it
                postgres    false            V           0    0    SCHEMA public    ACL     Q   REVOKE USAGE ON SCHEMA public FROM PUBLIC;
GRANT ALL ON SCHEMA public TO PUBLIC;
                   postgres    false    5            �            1255    74477 <   add_stock(integer, integer, integer, integer, integer, date) 	   PROCEDURE     \  CREATE PROCEDURE public.add_stock(IN product_id integer, IN warehouse_id integer, IN quantity integer, IN user_id integer, IN supplier_id integer, IN supply_date date)
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Tedarikçi ürün kaydını güncelle veya oluştur
    INSERT INTO supplier_product (supplier_id, product_id, supply_date, quantity)
    VALUES (supplier_id, product_id, supply_date, quantity)
    ON CONFLICT (supplier_id, product_id)
    DO UPDATE SET quantity = supplier_product.quantity + EXCLUDED.quantity;

    -- Depo stoğunu güncelle veya oluştur
    INSERT INTO product_warehouse (warehouse_id, product_id, stock_quantity, user_id)
    VALUES (warehouse_id, product_id, quantity, user_id)
    ON CONFLICT (warehouse_id, product_id)
    DO UPDATE SET stock_quantity = product_warehouse.stock_quantity + EXCLUDED.stock_quantity;
END;
$$;
 �   DROP PROCEDURE public.add_stock(IN product_id integer, IN warehouse_id integer, IN quantity integer, IN user_id integer, IN supplier_id integer, IN supply_date date);
       public          postgres    false    5            �            1255    74478    auto_log_stock_transaction()    FUNCTION     '  CREATE FUNCTION public.auto_log_stock_transaction() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Stok artışı durumunda 'add' işlemi olarak log ekle
    IF (TG_OP = 'INSERT') THEN
        INSERT INTO stock_transactions (user_id, warehouse_id, product_id, quantity, transaction_type, transaction_date)
        VALUES (
            NEW.user_id,
            NEW.warehouse_id,
            NEW.product_id,
            NEW.stock_quantity - COALESCE(OLD.stock_quantity, 0), -- Değişim miktarı
            CASE 
                WHEN NEW.stock_quantity > COALESCE(OLD.stock_quantity, 0) THEN 'add'
                ELSE 'remove'
            END,
            NOW()
        );
    END IF;

    -- Stok transferi için 'transfer_in' veya 'transfer_out' işlemi
    IF (TG_OP = 'UPDATE') THEN
        INSERT INTO stock_transactions (user_id, warehouse_id, product_id, quantity, transaction_type, transaction_date)
        VALUES (
            NEW.user_id,
            NEW.warehouse_id,
            NEW.product_id,
            ABS(NEW.stock_quantity - OLD.stock_quantity), -- Değişim miktarı
            CASE 
                WHEN NEW.stock_quantity > OLD.stock_quantity THEN 'transfer_in'
                ELSE 'transfer_out'
            END,
            NOW()
        );
    END IF;

    RETURN NEW;
END;
$$;
 3   DROP FUNCTION public.auto_log_stock_transaction();
       public          postgres    false    5            �            1255    74479    getstocktransactions()    FUNCTION     �  CREATE FUNCTION public.getstocktransactions() RETURNS TABLE("İşlem Türü" text, "İşlemi Yapan" text, "Ürün Adı" text, "Depo" text, "Miktar" integer, "Tarih" date)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY
    SELECT 
        st.transaction_type AS "İşlem Türü",
        u.user_name AS "İşlemi Yapan",
        p.product_name AS "Ürün Adı",
        COALESCE(w.ware_house_name, 'N/A') AS "Depo",
        st.quantity AS "Miktar",
        st.transaction_date AS "Tarih"
    FROM 
        stock_transactions st
    LEFT JOIN users u ON st.user_id = u.user_id
    LEFT JOIN products p ON st.product_id = p.product_id
    LEFT JOIN ware_houses w ON st.warehouse_id = w.ware_house_id
    ORDER BY st.transaction_date DESC;
END;
$$;
 -   DROP FUNCTION public.getstocktransactions();
       public          postgres    false    5            �            1255    74480 0   remove_stock(integer, integer, integer, integer) 	   PROCEDURE     O  CREATE PROCEDURE public.remove_stock(IN product_id integer, IN warehouse_id integer, IN quantity integer, IN user_id integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Depodaki stok miktarını kontrol et
    IF (SELECT stock_quantity FROM product_warehouse WHERE warehouse_id = warehouse_id AND product_id = product_id) < quantity THEN
        RAISE EXCEPTION 'Depoda yeterli stok yok!';
    END IF;

    -- Depo stoğunu güncelle
    UPDATE product_warehouse
    SET stock_quantity = stock_quantity - quantity
    WHERE warehouse_id = warehouse_id AND product_id = product_id;
END;
$$;
 }   DROP PROCEDURE public.remove_stock(IN product_id integer, IN warehouse_id integer, IN quantity integer, IN user_id integer);
       public          postgres    false    5            �            1255    74481 ;   transfer_stock(integer, integer, integer, integer, integer) 	   PROCEDURE     �  CREATE PROCEDURE public.transfer_stock(IN product_id integer, IN source_warehouse_id integer, IN target_warehouse_id integer, IN quantity integer, IN user_id integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Aynı depolar arasında transfer yapılamaz
    IF source_warehouse_id = target_warehouse_id THEN
        RAISE EXCEPTION 'Kaynak depo ve hedef depo aynı olamaz!';
    END IF;

    -- Kaynak depoda yeterli stok kontrolü
    IF (SELECT stock_quantity FROM product_warehouse WHERE warehouse_id = source_warehouse_id AND product_id = product_id) < quantity THEN
        RAISE EXCEPTION 'Kaynak depoda yeterli stok yok!';
    END IF;

    -- Kaynak depodan stok çıkar
    UPDATE product_warehouse
    SET stock_quantity = stock_quantity - quantity
    WHERE warehouse_id = source_warehouse_id AND product_id = product_id;

    -- Hedef depoya stok ekle
    INSERT INTO product_warehouse (warehouse_id, product_id, stock_quantity, user_id)
    VALUES (target_warehouse_id, product_id, quantity, user_id)
    ON CONFLICT (warehouse_id, product_id)
    DO UPDATE SET stock_quantity = product_warehouse.stock_quantity + EXCLUDED.stock_quantity;
END;
$$;
 �   DROP PROCEDURE public.transfer_stock(IN product_id integer, IN source_warehouse_id integer, IN target_warehouse_id integer, IN quantity integer, IN user_id integer);
       public          postgres    false    5            �            1259    74482 
   categories    TABLE     w   CREATE TABLE public.categories (
    category_id integer NOT NULL,
    category_name character varying(60) NOT NULL
);
    DROP TABLE public.categories;
       public         heap    postgres    false    5            �            1259    74485    categories_category_id_seq    SEQUENCE     �   ALTER TABLE public.categories ALTER COLUMN category_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.categories_category_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    209    5            �            1259    74486    product_warehouse    TABLE     �   CREATE TABLE public.product_warehouse (
    product_warehouse_id integer NOT NULL,
    product_id integer NOT NULL,
    warehouse_id integer NOT NULL,
    stock_quantity integer NOT NULL
);
 %   DROP TABLE public.product_warehouse;
       public         heap    postgres    false    5            �            1259    74489 *   product_warehouse_product_warehouse_id_seq    SEQUENCE       ALTER TABLE public.product_warehouse ALTER COLUMN product_warehouse_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.product_warehouse_product_warehouse_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    211    5            �            1259    74490    products    TABLE     �   CREATE TABLE public.products (
    product_id integer NOT NULL,
    product_name character varying(80) NOT NULL,
    category_id integer NOT NULL,
    unit_price integer,
    min_stock_level integer NOT NULL,
    supplier_id character varying
);
    DROP TABLE public.products;
       public         heap    postgres    false    5            �            1259    74495    products_product_id_seq    SEQUENCE     �   ALTER TABLE public.products ALTER COLUMN product_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.products_product_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    5    213            �            1259    74496    roles    TABLE     j   CREATE TABLE public.roles (
    role_id integer NOT NULL,
    role_name character varying(20) NOT NULL
);
    DROP TABLE public.roles;
       public         heap    postgres    false    5            �            1259    74499    roles_role_id_seq    SEQUENCE     �   ALTER TABLE public.roles ALTER COLUMN role_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.roles_role_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    5    215            �            1259    74500    stock_transactions    TABLE     /  CREATE TABLE public.stock_transactions (
    transaction_id integer NOT NULL,
    product_id integer NOT NULL,
    user_id integer NOT NULL,
    transaction_type character varying(90) NOT NULL,
    quantity character varying(90) NOT NULL,
    transaction_date date NOT NULL,
    warehouse_id integer
);
 &   DROP TABLE public.stock_transactions;
       public         heap    postgres    false    5            �            1259    74503 %   stock_transactions_transaction_id_seq    SEQUENCE     �   ALTER TABLE public.stock_transactions ALTER COLUMN transaction_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.stock_transactions_transaction_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    5    217            �            1259    74504    supplier_product    TABLE     �   CREATE TABLE public.supplier_product (
    supllier_product_id integer NOT NULL,
    supplier_id integer NOT NULL,
    product_id integer NOT NULL,
    supply_date date NOT NULL,
    quantity integer
);
 $   DROP TABLE public.supplier_product;
       public         heap    postgres    false    5            �            1259    74507 (   supplier_product_supllier_product_id_seq    SEQUENCE     �   ALTER TABLE public.supplier_product ALTER COLUMN supllier_product_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.supplier_product_supllier_product_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219    5            �            1259    74508 	   suppliers    TABLE     �   CREATE TABLE public.suppliers (
    supplier_id integer NOT NULL,
    supplier_name character varying NOT NULL,
    phone character varying NOT NULL
);
    DROP TABLE public.suppliers;
       public         heap    postgres    false    5            �            1259    74513    suppliers_supplier_id_seq    SEQUENCE     �   ALTER TABLE public.suppliers ALTER COLUMN supplier_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.suppliers_supplier_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    221    5            �            1259    74514    users    TABLE     �   CREATE TABLE public.users (
    user_id integer NOT NULL,
    user_name character varying(20) NOT NULL,
    user_surname character varying(30) NOT NULL,
    rol_id integer NOT NULL,
    password character varying(100) NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false    5            �            1259    74517    users_user_id_seq    SEQUENCE     �   ALTER TABLE public.users ALTER COLUMN user_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.users_user_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    223    5            �            1259    74518    ware_houses    TABLE     �   CREATE TABLE public.ware_houses (
    ware_house_id integer NOT NULL,
    ware_house_name character varying(50) NOT NULL,
    address character varying(255) NOT NULL
);
    DROP TABLE public.ware_houses;
       public         heap    postgres    false    5            �            1259    74521    ware_houses_ware_house_id_seq    SEQUENCE     �   ALTER TABLE public.ware_houses ALTER COLUMN ware_house_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.ware_houses_ware_house_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    5    225            >          0    74482 
   categories 
   TABLE DATA           @   COPY public.categories (category_id, category_name) FROM stdin;
    public          postgres    false    209   �q       @          0    74486    product_warehouse 
   TABLE DATA           k   COPY public.product_warehouse (product_warehouse_id, product_id, warehouse_id, stock_quantity) FROM stdin;
    public          postgres    false    211   �q       B          0    74490    products 
   TABLE DATA           s   COPY public.products (product_id, product_name, category_id, unit_price, min_stock_level, supplier_id) FROM stdin;
    public          postgres    false    213   xr       D          0    74496    roles 
   TABLE DATA           3   COPY public.roles (role_id, role_name) FROM stdin;
    public          postgres    false    215   _s       F          0    74500    stock_transactions 
   TABLE DATA           �   COPY public.stock_transactions (transaction_id, product_id, user_id, transaction_type, quantity, transaction_date, warehouse_id) FROM stdin;
    public          postgres    false    217   �s       H          0    74504    supplier_product 
   TABLE DATA           o   COPY public.supplier_product (supllier_product_id, supplier_id, product_id, supply_date, quantity) FROM stdin;
    public          postgres    false    219   u       J          0    74508 	   suppliers 
   TABLE DATA           F   COPY public.suppliers (supplier_id, supplier_name, phone) FROM stdin;
    public          postgres    false    221   ru       L          0    74514    users 
   TABLE DATA           S   COPY public.users (user_id, user_name, user_surname, rol_id, password) FROM stdin;
    public          postgres    false    223   �u       N          0    74518    ware_houses 
   TABLE DATA           N   COPY public.ware_houses (ware_house_id, ware_house_name, address) FROM stdin;
    public          postgres    false    225   v       W           0    0    categories_category_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.categories_category_id_seq', 7, true);
          public          postgres    false    210            X           0    0 *   product_warehouse_product_warehouse_id_seq    SEQUENCE SET     Y   SELECT pg_catalog.setval('public.product_warehouse_product_warehouse_id_seq', 27, true);
          public          postgres    false    212            Y           0    0    products_product_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.products_product_id_seq', 12, true);
          public          postgres    false    214            Z           0    0    roles_role_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.roles_role_id_seq', 15, true);
          public          postgres    false    216            [           0    0 %   stock_transactions_transaction_id_seq    SEQUENCE SET     T   SELECT pg_catalog.setval('public.stock_transactions_transaction_id_seq', 36, true);
          public          postgres    false    218            \           0    0 (   supplier_product_supllier_product_id_seq    SEQUENCE SET     W   SELECT pg_catalog.setval('public.supplier_product_supllier_product_id_seq', 13, true);
          public          postgres    false    220            ]           0    0    suppliers_supplier_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.suppliers_supplier_id_seq', 1, true);
          public          postgres    false    222            ^           0    0    users_user_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.users_user_id_seq', 15, true);
          public          postgres    false    224            _           0    0    ware_houses_ware_house_id_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public.ware_houses_ware_house_id_seq', 4, true);
          public          postgres    false    226            �           2606    74523    categories categories_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.categories
    ADD CONSTRAINT categories_pkey PRIMARY KEY (category_id);
 D   ALTER TABLE ONLY public.categories DROP CONSTRAINT categories_pkey;
       public            postgres    false    209            �           2606    74525 (   product_warehouse product_warehouse_pkey 
   CONSTRAINT     x   ALTER TABLE ONLY public.product_warehouse
    ADD CONSTRAINT product_warehouse_pkey PRIMARY KEY (product_warehouse_id);
 R   ALTER TABLE ONLY public.product_warehouse DROP CONSTRAINT product_warehouse_pkey;
       public            postgres    false    211            �           2606    74527    products products_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (product_id);
 @   ALTER TABLE ONLY public.products DROP CONSTRAINT products_pkey;
       public            postgres    false    213            �           2606    74529    roles roles_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pkey PRIMARY KEY (role_id);
 :   ALTER TABLE ONLY public.roles DROP CONSTRAINT roles_pkey;
       public            postgres    false    215            �           2606    74531 *   stock_transactions stock_transactions_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public.stock_transactions
    ADD CONSTRAINT stock_transactions_pkey PRIMARY KEY (transaction_id);
 T   ALTER TABLE ONLY public.stock_transactions DROP CONSTRAINT stock_transactions_pkey;
       public            postgres    false    217            �           2606    74533 &   supplier_product supplier_product_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public.supplier_product
    ADD CONSTRAINT supplier_product_pkey PRIMARY KEY (supllier_product_id);
 P   ALTER TABLE ONLY public.supplier_product DROP CONSTRAINT supplier_product_pkey;
       public            postgres    false    219            �           2606    74535    suppliers suppliers_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.suppliers
    ADD CONSTRAINT suppliers_pkey PRIMARY KEY (supplier_id);
 B   ALTER TABLE ONLY public.suppliers DROP CONSTRAINT suppliers_pkey;
       public            postgres    false    221            �           2606    74537 (   supplier_product unique_supplier_product 
   CONSTRAINT     v   ALTER TABLE ONLY public.supplier_product
    ADD CONSTRAINT unique_supplier_product UNIQUE (supplier_id, product_id);
 R   ALTER TABLE ONLY public.supplier_product DROP CONSTRAINT unique_supplier_product;
       public            postgres    false    219    219            �           2606    74539 *   product_warehouse unique_warehouse_product 
   CONSTRAINT     y   ALTER TABLE ONLY public.product_warehouse
    ADD CONSTRAINT unique_warehouse_product UNIQUE (warehouse_id, product_id);
 T   ALTER TABLE ONLY public.product_warehouse DROP CONSTRAINT unique_warehouse_product;
       public            postgres    false    211    211            �           2606    74541    users users_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (user_id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    223            �           2606    74543    ware_houses ware_houses_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public.ware_houses
    ADD CONSTRAINT ware_houses_pkey PRIMARY KEY (ware_house_id);
 F   ALTER TABLE ONLY public.ware_houses DROP CONSTRAINT ware_houses_pkey;
       public            postgres    false    225            �           1259    74544    fki_fk_product    INDEX     Q   CREATE INDEX fki_fk_product ON public.supplier_product USING btree (product_id);
 "   DROP INDEX public.fki_fk_product;
       public            postgres    false    219            �           1259    74545    fki_fk_suplier    INDEX     R   CREATE INDEX fki_fk_suplier ON public.supplier_product USING btree (supplier_id);
 "   DROP INDEX public.fki_fk_suplier;
       public            postgres    false    219            �           1259    74546    fki_fk_ware_house    INDEX     X   CREATE INDEX fki_fk_ware_house ON public.stock_transactions USING btree (warehouse_id);
 %   DROP INDEX public.fki_fk_ware_house;
       public            postgres    false    217            �           1259    74547    fki_p    INDEX     A   CREATE INDEX fki_p ON public.products USING btree (category_id);
    DROP INDEX public.fki_p;
       public            postgres    false    213            �           1259    74548    fki_product_id_fk    INDEX     V   CREATE INDEX fki_product_id_fk ON public.stock_transactions USING btree (product_id);
 %   DROP INDEX public.fki_product_id_fk;
       public            postgres    false    217            �           1259    74549 !   fki_product_ware_house_product_id    INDEX     e   CREATE INDEX fki_product_ware_house_product_id ON public.product_warehouse USING btree (product_id);
 5   DROP INDEX public.fki_product_ware_house_product_id;
       public            postgres    false    211            �           1259    74550 $   fki_product_warehouse_warehouseid_pk    INDEX     j   CREATE INDEX fki_product_warehouse_warehouseid_pk ON public.product_warehouse USING btree (warehouse_id);
 8   DROP INDEX public.fki_product_warehouse_warehouseid_pk;
       public            postgres    false    211            �           1259    74551    fki_user_id_fk    INDEX     P   CREATE INDEX fki_user_id_fk ON public.stock_transactions USING btree (user_id);
 "   DROP INDEX public.fki_user_id_fk;
       public            postgres    false    217            �           1259    74552    fki_user_roles_foreign    INDEX     J   CREATE INDEX fki_user_roles_foreign ON public.users USING btree (rol_id);
 *   DROP INDEX public.fki_user_roles_foreign;
       public            postgres    false    223            �           1259    74553    fki_w    INDEX     L   CREATE INDEX fki_w ON public.stock_transactions USING btree (warehouse_id);
    DROP INDEX public.fki_w;
       public            postgres    false    217            �           2606    74554    products category_id_pk    FK CONSTRAINT     �   ALTER TABLE ONLY public.products
    ADD CONSTRAINT category_id_pk FOREIGN KEY (category_id) REFERENCES public.categories(category_id) NOT VALID;
 A   ALTER TABLE ONLY public.products DROP CONSTRAINT category_id_pk;
       public          postgres    false    213    209    3210            �           2606    74559    supplier_product fk_product    FK CONSTRAINT     �   ALTER TABLE ONLY public.supplier_product
    ADD CONSTRAINT fk_product FOREIGN KEY (product_id) REFERENCES public.products(product_id) NOT VALID;
 E   ALTER TABLE ONLY public.supplier_product DROP CONSTRAINT fk_product;
       public          postgres    false    219    213    3219            �           2606    74564    supplier_product fk_suplier    FK CONSTRAINT     �   ALTER TABLE ONLY public.supplier_product
    ADD CONSTRAINT fk_suplier FOREIGN KEY (supplier_id) REFERENCES public.suppliers(supplier_id) NOT VALID;
 E   ALTER TABLE ONLY public.supplier_product DROP CONSTRAINT fk_suplier;
       public          postgres    false    3235    219    221            �           2606    74569     stock_transactions fk_ware_house    FK CONSTRAINT     �   ALTER TABLE ONLY public.stock_transactions
    ADD CONSTRAINT fk_ware_house FOREIGN KEY (warehouse_id) REFERENCES public.ware_houses(ware_house_id) NOT VALID;
 J   ALTER TABLE ONLY public.stock_transactions DROP CONSTRAINT fk_ware_house;
       public          postgres    false    225    217    3240            �           2606    74574 "   stock_transactions fk_warehouse_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.stock_transactions
    ADD CONSTRAINT fk_warehouse_id FOREIGN KEY (warehouse_id) REFERENCES public.ware_houses(ware_house_id) NOT VALID;
 L   ALTER TABLE ONLY public.stock_transactions DROP CONSTRAINT fk_warehouse_id;
       public          postgres    false    3240    217    225            �           2606    74579     stock_transactions product_id_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.stock_transactions
    ADD CONSTRAINT product_id_fk FOREIGN KEY (product_id) REFERENCES public.products(product_id) NOT VALID;
 J   ALTER TABLE ONLY public.stock_transactions DROP CONSTRAINT product_id_fk;
       public          postgres    false    3219    213    217            �           2606    74584 /   product_warehouse product_ware_house_product_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.product_warehouse
    ADD CONSTRAINT product_ware_house_product_id FOREIGN KEY (product_id) REFERENCES public.products(product_id) NOT VALID;
 Y   ALTER TABLE ONLY public.product_warehouse DROP CONSTRAINT product_ware_house_product_id;
       public          postgres    false    3219    211    213            �           2606    74589 2   product_warehouse product_warehouse_warehouseid_pk    FK CONSTRAINT     �   ALTER TABLE ONLY public.product_warehouse
    ADD CONSTRAINT product_warehouse_warehouseid_pk FOREIGN KEY (warehouse_id) REFERENCES public.ware_houses(ware_house_id) NOT VALID;
 \   ALTER TABLE ONLY public.product_warehouse DROP CONSTRAINT product_warehouse_warehouseid_pk;
       public          postgres    false    225    3240    211            �           2606    74594    stock_transactions user_id_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.stock_transactions
    ADD CONSTRAINT user_id_fk FOREIGN KEY (user_id) REFERENCES public.users(user_id) NOT VALID;
 G   ALTER TABLE ONLY public.stock_transactions DROP CONSTRAINT user_id_fk;
       public          postgres    false    217    223    3238            �           2606    74599    users user_roles_foreign    FK CONSTRAINT     �   ALTER TABLE ONLY public.users
    ADD CONSTRAINT user_roles_foreign FOREIGN KEY (rol_id) REFERENCES public.roles(role_id) NOT VALID;
 B   ALTER TABLE ONLY public.users DROP CONSTRAINT user_roles_foreign;
       public          postgres    false    215    223    3221            >   K   x�3�t�I�.)�����2�tϬ���2���O�̩L�2��ί�M-J�rzg�$p�qFޓ����Y������ �#%      @   k   x���� C��a��4�t�9� �x�"��,������A��Zk.���k�~嘥���6��_LQ��<�ې�ż{ܺ�r�N��%qO���?��1      B   �   x�5�AN�0E�?��@��@X�.C�.�TWXq�(u+���gG�� ��͛�c�Ds�3,lg��5�=W[�9|}�Ĩ�	h��s-��I,'̩�b{����{�д���#orr��wr,��p/�=6t$�t�u���/���	�L�Q��K���z��a�S`�H-���R=�B���h�a�y����ɵ?�aE˞F��_��VU���Hz      D   '   x�34�tL����24��M�KLO-�24�-�1z\\\ �GT      F   h  x���_N�0Ɵ���Ο���LB�V$4�Iep���`�MJ�2������/v����/�ql�ZrM���������0��|�A/�*�i��M��,0��1��8�~�]
ؑ��6��X$է =t��_ `�����g 2��d"&D�C�a�%�	mL�KC��e�~�D����}�m��z�����4?��.�;E=�4D{YԦ�pۈ/양5��h��t1D�R��&���ShO�*��%���9�5&^5�^!^�y:��'pE���\Ĕ��R�$}TS��z��@�-�b~}��k��ƫx��n�f�������]5����״�ë���*�������      H   T   x�U���0���(6mwa�9���b+9!48�6yӄ"��WP���hȃU@��Uy�5�6;U����\[^P������      J   )   x�3�IMI,��N�4��056�T012�5631����� �5V      L   `   x�34�t���<�1'7���И� ���<�(��Ș�Єӱ���TN����"N 771/1=���Ԍ�Д�1#7��3$5�(i�YZ�Zdna�����  g�      N   C   x�3��M-�N�RpI-��t��N,J�2�<:�4),�`�ydCqIb^Ri�1��P�*7��+F��� �U�     