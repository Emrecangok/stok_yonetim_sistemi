PGDMP      4            
    |            stok_yonetim    14.13    16.4 +    %           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            &           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            '           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            (           1262    32888    stok_yonetim    DATABASE     �   CREATE DATABASE stok_yonetim WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_T�rkiye.1254';
    DROP DATABASE stok_yonetim;
                postgres    false                        2615    2200    public    SCHEMA     2   -- *not* creating schema, since initdb creates it
 2   -- *not* dropping schema, since initdb creates it
                postgres    false            )           0    0    SCHEMA public    ACL     Q   REVOKE USAGE ON SCHEMA public FROM PUBLIC;
GRANT ALL ON SCHEMA public TO PUBLIC;
                   postgres    false    4            �            1259    32914 
   categories    TABLE     w   CREATE TABLE public.categories (
    category_id integer NOT NULL,
    category_name character varying(60) NOT NULL
);
    DROP TABLE public.categories;
       public         heap    postgres    false    4            �            1259    32913    categories_category_id_seq    SEQUENCE     �   ALTER TABLE public.categories ALTER COLUMN category_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.categories_category_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    4    216            �            1259    32932    product_warehouse    TABLE     �   CREATE TABLE public.product_warehouse (
    product_warehouse_id integer NOT NULL,
    product_id integer NOT NULL,
    warehouse_id integer NOT NULL,
    stock_quantity integer NOT NULL
);
 %   DROP TABLE public.product_warehouse;
       public         heap    postgres    false    4            �            1259    32931 *   product_warehouse_product_warehouse_id_seq    SEQUENCE       ALTER TABLE public.product_warehouse ALTER COLUMN product_warehouse_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.product_warehouse_product_warehouse_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    222    4            �            1259    32908    products    TABLE     �   CREATE TABLE public.products (
    product_id integer NOT NULL,
    product_name character varying(80) NOT NULL,
    category_id integer NOT NULL,
    unit_price integer,
    current_stock integer NOT NULL,
    min_stock_level integer NOT NULL
);
    DROP TABLE public.products;
       public         heap    postgres    false    4            �            1259    32907    products_product_id_seq    SEQUENCE     �   ALTER TABLE public.products ALTER COLUMN product_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.products_product_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    4    214            �            1259    32894    roles    TABLE     j   CREATE TABLE public.roles (
    role_id integer NOT NULL,
    role_name character varying(20) NOT NULL
);
    DROP TABLE public.roles;
       public         heap    postgres    false    4            �            1259    32905    roles_role_id_seq    SEQUENCE     �   ALTER TABLE public.roles ALTER COLUMN role_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.roles_role_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    4    210            �            1259    32920    stock_transactions    TABLE       CREATE TABLE public.stock_transactions (
    transaction_id integer NOT NULL,
    product_id integer NOT NULL,
    user_id integer NOT NULL,
    transactin_type character varying(90) NOT NULL,
    quantity character varying(90) NOT NULL,
    transaction_date date NOT NULL
);
 &   DROP TABLE public.stock_transactions;
       public         heap    postgres    false    4            �            1259    32919 %   stock_transactions_transaction_id_seq    SEQUENCE     �   ALTER TABLE public.stock_transactions ALTER COLUMN transaction_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.stock_transactions_transaction_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    4    218            �            1259    32889    users    TABLE     �   CREATE TABLE public.users (
    user_id integer NOT NULL,
    user_name character varying(20) NOT NULL,
    user_surname character varying(30) NOT NULL,
    rol_id integer NOT NULL,
    password character varying(100) NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false    4            �            1259    32906    users_user_id_seq    SEQUENCE     �   ALTER TABLE public.users ALTER COLUMN user_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.users_user_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    4    209            �            1259    32926    ware_houses    TABLE     �   CREATE TABLE public.ware_houses (
    ware_house_id integer NOT NULL,
    ware_house_name character varying(50) NOT NULL,
    address character varying(255) NOT NULL
);
    DROP TABLE public.ware_houses;
       public         heap    postgres    false    4            �            1259    32925    ware_houses_ware_house_id_seq    SEQUENCE     �   ALTER TABLE public.ware_houses ALTER COLUMN ware_house_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.ware_houses_ware_house_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    220    4                      0    32914 
   categories 
   TABLE DATA           @   COPY public.categories (category_id, category_name) FROM stdin;
    public          postgres    false    216   �1       "          0    32932    product_warehouse 
   TABLE DATA           k   COPY public.product_warehouse (product_warehouse_id, product_id, warehouse_id, stock_quantity) FROM stdin;
    public          postgres    false    222   
2                 0    32908    products 
   TABLE DATA           u   COPY public.products (product_id, product_name, category_id, unit_price, current_stock, min_stock_level) FROM stdin;
    public          postgres    false    214   '2                 0    32894    roles 
   TABLE DATA           3   COPY public.roles (role_id, role_name) FROM stdin;
    public          postgres    false    210   D2                 0    32920    stock_transactions 
   TABLE DATA           ~   COPY public.stock_transactions (transaction_id, product_id, user_id, transactin_type, quantity, transaction_date) FROM stdin;
    public          postgres    false    218   r2                 0    32889    users 
   TABLE DATA           S   COPY public.users (user_id, user_name, user_surname, rol_id, password) FROM stdin;
    public          postgres    false    209   �2                  0    32926    ware_houses 
   TABLE DATA           N   COPY public.ware_houses (ware_house_id, ware_house_name, address) FROM stdin;
    public          postgres    false    220   �2       *           0    0    categories_category_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.categories_category_id_seq', 1, false);
          public          postgres    false    215            +           0    0 *   product_warehouse_product_warehouse_id_seq    SEQUENCE SET     Y   SELECT pg_catalog.setval('public.product_warehouse_product_warehouse_id_seq', 1, false);
          public          postgres    false    221            ,           0    0    products_product_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.products_product_id_seq', 1, false);
          public          postgres    false    213            -           0    0    roles_role_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.roles_role_id_seq', 2, true);
          public          postgres    false    211            .           0    0 %   stock_transactions_transaction_id_seq    SEQUENCE SET     T   SELECT pg_catalog.setval('public.stock_transactions_transaction_id_seq', 1, false);
          public          postgres    false    217            /           0    0    users_user_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.users_user_id_seq', 3, true);
          public          postgres    false    212            0           0    0    ware_houses_ware_house_id_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public.ware_houses_ware_house_id_seq', 1, false);
          public          postgres    false    219            �           2606    32918    categories categories_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.categories
    ADD CONSTRAINT categories_pkey PRIMARY KEY (category_id);
 D   ALTER TABLE ONLY public.categories DROP CONSTRAINT categories_pkey;
       public            postgres    false    216            �           2606    32936 (   product_warehouse product_warehouse_pkey 
   CONSTRAINT     x   ALTER TABLE ONLY public.product_warehouse
    ADD CONSTRAINT product_warehouse_pkey PRIMARY KEY (product_warehouse_id);
 R   ALTER TABLE ONLY public.product_warehouse DROP CONSTRAINT product_warehouse_pkey;
       public            postgres    false    222            �           2606    32912    products products_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (product_id);
 @   ALTER TABLE ONLY public.products DROP CONSTRAINT products_pkey;
       public            postgres    false    214            ~           2606    32898    roles roles_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pkey PRIMARY KEY (role_id);
 :   ALTER TABLE ONLY public.roles DROP CONSTRAINT roles_pkey;
       public            postgres    false    210            �           2606    32924 *   stock_transactions stock_transactions_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public.stock_transactions
    ADD CONSTRAINT stock_transactions_pkey PRIMARY KEY (transaction_id);
 T   ALTER TABLE ONLY public.stock_transactions DROP CONSTRAINT stock_transactions_pkey;
       public            postgres    false    218            |           2606    32893    users users_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (user_id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    209            �           2606    32930    ware_houses ware_houses_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public.ware_houses
    ADD CONSTRAINT ware_houses_pkey PRIMARY KEY (ware_house_id);
 F   ALTER TABLE ONLY public.ware_houses DROP CONSTRAINT ware_houses_pkey;
       public            postgres    false    220            z           1259    32904    fki_user_roles_foreign    INDEX     J   CREATE INDEX fki_user_roles_foreign ON public.users USING btree (rol_id);
 *   DROP INDEX public.fki_user_roles_foreign;
       public            postgres    false    209            �           2606    32899    users user_roles_foreign    FK CONSTRAINT     �   ALTER TABLE ONLY public.users
    ADD CONSTRAINT user_roles_foreign FOREIGN KEY (rol_id) REFERENCES public.roles(role_id) NOT VALID;
 B   ALTER TABLE ONLY public.users DROP CONSTRAINT user_roles_foreign;
       public          postgres    false    210    209    3198                  x������ � �      "      x������ � �            x������ � �            x�3�tL����2���/�M������ D��            x������ � �         +   x�3�L�-JMN��L���4����ML���\���L� `�             x������ � �     