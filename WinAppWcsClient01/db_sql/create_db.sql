
-- ----------------------------
-- Table structure for im_item
-- ----------------------------
DROP TABLE IF EXISTS main.im_item;
CREATE TABLE main.im_item (
  im_item_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  product_no integer NOT NULL,
  item_no varchar(50) NOT NULL,
  item_desc varchar(100) null ,
  customer_id integer default 0 ,
  remark_desc varchar(50) null ,
  void integer default 0 ,
  update_time timestamp,
  update_uid integer default 0 
)
;

-- ----------------------------
-- Uniques structure for table im_item
-- ----------------------------
CREATE UNIQUE INDEX uk_product_no
ON im_item (
product_no ASC
);


-- ----------------------------
-- Table structure for im_item_barcode
-- ----------------------------
DROP TABLE IF EXISTS main.im_item_barcode;
CREATE TABLE main.im_item_barcode (
  im_item_barcode_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  product_no integer NOT NULL,
  customer_id integer NOT NULL,
  item_barcode varchar(50) NOT NULL,
  remark_desc varchar(50) null ,
  void integer default 0 ,
  update_time timestamp,
  update_uid integer default 0 
)
;


-- ----------------------------
-- Uniques structure for table im_item_barcode
-- ----------------------------
CREATE UNIQUE INDEX uk_barcode_custid
ON im_item_barcode (
    customer_id,
    item_barcode ASC
);



-- ----------------------------
-- Table structure for loc_area
-- ----------------------------
DROP TABLE IF EXISTS main.loc_area;
CREATE TABLE main.loc_area (
  loc_area_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  area_no varchar(5) null ,
  area_desc varchar(50) null ,
  area_type_id integer default 0 ,
  area_group_id integer default 0 ,
  warehouse_id integer default 0 ,
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 ,
  x_point integer default 0  DEFAULT 0,
  y_point integer default 0  DEFAULT 0
)
;


-- ----------------------------
-- Table structure for loc_area_group
-- ----------------------------
DROP TABLE IF EXISTS main.loc_area_group;
CREATE TABLE main.loc_area_group (
  loc_area_group_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  area_group_id integer NOT NULL,
  area_group_desc varchar(50) null ,
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 
)
;



-- ----------------------------
-- Table structure for loc_area_type
-- ----------------------------
DROP TABLE IF EXISTS main.loc_area_type;
CREATE TABLE main.loc_area_type (
  loc_area_type_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  area_type_id integer NOT NULL,
  area_type_desc varchar(50) NOT NULL,
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 
)
;




-- ----------------------------
-- Table structure for loc_lane
-- ----------------------------
DROP TABLE IF EXISTS main.loc_lane;
CREATE TABLE main.loc_lane (
  loc_lane_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  lane_no varchar(10) NOT NULL,
  lane_desc varchar(50) null ,
  area_no varchar(5) NOT NULL,
  lane_pri integer default 0  DEFAULT 0,
  layers_set integer default 0  DEFAULT 0,
  x_point integer default 0  DEFAULT 0,
  y_point integer default 0  DEFAULT 0,
  lane_direction varchar(1) null ,
  lane_order varchar(3) null ,
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 
)
;




-- ----------------------------
-- Table structure for loc_location
-- ----------------------------
DROP TABLE IF EXISTS main.loc_location;
CREATE TABLE main.loc_location (
  loc_location_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  location_no varchar(20) NOT NULL,
  shelf_no varchar(20) null ,
  abc_class varchar(5) null ,
  location_desc varchar(50) null ,
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 
)
;


-- ----------------------------
-- Table structure for loc_location_hold
-- ----------------------------
DROP TABLE IF EXISTS main.loc_location_hold;
CREATE TABLE main.loc_location_hold (
  loc_location_hold_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  location_no varchar(20) NOT NULL,
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  hold_time timestamptz(6),
  hold_uid integer default 0 ,
  release_time timestamptz(6),
  release_uid integer default 0 ,
  update_time timestamp,
  update_uid integer default 0 
)
;



-- ----------------------------
-- Table structure for loc_shelf
-- ----------------------------
DROP TABLE IF EXISTS main.loc_shelf;
CREATE TABLE main.loc_shelf (
  loc_shelf_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  shelf_no varchar(20) NOT NULL,
  lane_no varchar(10) NOT NULL,
  shelf_index integer default 0  DEFAULT 0,
  shelf_desc varchar(50) null ,
  layers_set integer default 0  DEFAULT 0,
  locs_set integer default 0  DEFAULT 0,
  storage_type_id integer default 0 ,
  shelf_pri integer default 0 ,
  abc_class varchar(5) null ,
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 
)
;


-- ----------------------------
-- Table structure for loc_storage_type
-- ----------------------------
DROP TABLE IF EXISTS main.loc_storage_type;
CREATE TABLE main.loc_storage_type (
  loc_storage_type_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  storage_type_id integer default 0 ,
  storage_type_desc varchar(50) null ,
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 
)
;



-- ----------------------------
-- Table structure for loc_warehouse
-- ----------------------------
DROP TABLE IF EXISTS main.loc_warehouse;
CREATE TABLE main.loc_warehouse (
  loc_warehouse_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  warehouse_id integer NOT NULL,
  warehouse_desc varchar(50) NOT NULL,
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 
)
;



-- ----------------------------
-- Table structure for um_user
-- ----------------------------
DROP TABLE IF EXISTS main.um_user;
CREATE TABLE main.um_user (
  um_user_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  user_id integer NOT NULL,
  login_name varchar(50) NOT NULL,
  login_pwd varchar(50) null ,
  user_dep_id integer default 0 ,
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 
)
;

-- ----------------------------
-- Table structure for bc_system_no
-- ----------------------------
DROP TABLE IF EXISTS main.bc_system_no;
CREATE TABLE main.bc_system_no (
  bc_system_no_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  system_no integer NOT NULL,
  id_type varchar(50) NOT NULL,  
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 
)
;

-- ----------------------------
-- Table structure for bc_customer
-- ----------------------------
DROP TABLE IF EXISTS main.bc_customer;
CREATE TABLE main.bc_customer (
  bc_customer_id integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  customer_id integer NOT NULL,
  customer_desc varchar(50) NOT NULL,  
  remark_desc varchar(50) null ,
  void integer default 0  DEFAULT 0,
  update_time timestamp,
  update_uid integer default 0 
)
;

insert into bc_customer (customer_id,customer_desc,void) values (0,'默认客户',0)

