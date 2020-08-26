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

 Date: 18/08/2020 14:31:34
*/


-- ----------------------------
-- Table structure for loc_location
-- ----------------------------
DROP TABLE IF EXISTS "public"."loc_location";
CREATE TABLE "public"."loc_location" (
  "loc_location_id" int4 NOT NULL DEFAULT nextval('loc_location_id_seq'::regclass),
  "location_no" varchar(20) COLLATE "pg_catalog"."default" NOT NULL,
  "shelf_no" varchar(20) COLLATE "pg_catalog"."default",
  "abc_class" varchar(5) COLLATE "pg_catalog"."default",
  "location_desc" varchar(50) COLLATE "pg_catalog"."default",
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4 DEFAULT 0,
  "update_time" timestamptz(6),
  "update_uid" int4
)
;

-- ----------------------------
-- Primary Key structure for table loc_location
-- ----------------------------
ALTER TABLE "public"."loc_location" ADD CONSTRAINT "loc_location_pkey" PRIMARY KEY ("loc_location_id");
