/*
 Navicat Premium Data Transfer

 Source Server         : 127.0.0.1
 Source Server Type    : PostgreSQL
 Source Server Version : 90617
 Source Host           : 127.0.0.1:5432
 Source Catalog        : wcs_db_01
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 90617
 File Encoding         : 65001

 Date: 18/08/2020 14:31:57
*/


-- ----------------------------
-- Table structure for loc_shelf
-- ----------------------------
DROP TABLE IF EXISTS "public"."loc_shelf";
CREATE TABLE "public"."loc_shelf" (
  "loc_shelf_id" int4 NOT NULL DEFAULT nextval('loc_shelf_id_seq'::regclass),
  "shelf_no" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "lane_no" varchar(10) COLLATE "pg_catalog"."default" NOT NULL,
  "shelf_index" int4 DEFAULT 0,
  "shelf_desc" varchar(50) COLLATE "pg_catalog"."default",
  "layers_set" int4 DEFAULT 0,
  "locs_set" int4 DEFAULT 0,
  "storage_type_id" int4,
  "shelf_pri" int4,
  "abc_class" varchar(5) COLLATE "pg_catalog"."default",
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4 DEFAULT 0,
  "update_time" timestamptz(6),
  "update_uid" int4
)
;

-- ----------------------------
-- Primary Key structure for table loc_shelf
-- ----------------------------
ALTER TABLE "public"."loc_shelf" ADD CONSTRAINT "loc_shelf_pkey" PRIMARY KEY ("loc_shelf_id");
