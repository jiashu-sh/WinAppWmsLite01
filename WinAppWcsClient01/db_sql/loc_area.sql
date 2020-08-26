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

 Date: 18/08/2020 14:30:59
*/


-- ----------------------------
-- Table structure for loc_area
-- ----------------------------
DROP TABLE IF EXISTS "public"."loc_area";
CREATE TABLE "public"."loc_area" (
  "loc_area_id" int4 NOT NULL DEFAULT nextval('loc_area_id_seq'::regclass),
  "area_no" varchar(5) COLLATE "pg_catalog"."default",
  "area_desc" varchar(50) COLLATE "pg_catalog"."default",
  "area_type_id" int4,
  "area_group_id" int4,
  "warehouse_id" int4,
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4 DEFAULT 0,
  "update_time" timestamptz(6),
  "update_uid" int4,
  "x_point" int4 DEFAULT 0,
  "y_point" int4 DEFAULT 0
)
;

-- ----------------------------
-- Primary Key structure for table loc_area
-- ----------------------------
ALTER TABLE "public"."loc_area" ADD CONSTRAINT "loc_area_pkey" PRIMARY KEY ("loc_area_id");
