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

 Date: 18/08/2020 14:31:16
*/


-- ----------------------------
-- Table structure for loc_area_type
-- ----------------------------
DROP TABLE IF EXISTS "public"."loc_area_type";
CREATE TABLE "public"."loc_area_type" (
  "loc_area_type_id" int4 NOT NULL DEFAULT nextval('loc_area_type_id_seq'::regclass),
  "area_type_id" int4 NOT NULL,
  "area_type_desc" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4 DEFAULT 0,
  "update_time" timestamptz(6),
  "update_uid" int4
)
;

-- ----------------------------
-- Primary Key structure for table loc_area_type
-- ----------------------------
ALTER TABLE "public"."loc_area_type" ADD CONSTRAINT "loc_area_type_pkey" PRIMARY KEY ("loc_area_type_id");
