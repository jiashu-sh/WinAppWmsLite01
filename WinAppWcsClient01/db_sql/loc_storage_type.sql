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

 Date: 18/08/2020 14:32:05
*/


-- ----------------------------
-- Table structure for loc_storage_type
-- ----------------------------
DROP TABLE IF EXISTS "public"."loc_storage_type";
CREATE TABLE "public"."loc_storage_type" (
  "loc_storage_type_id" int4 NOT NULL DEFAULT nextval('loc_storage_type_id_seq'::regclass),
  "storage_type_id" int4,
  "storage_type_desc" varchar(50) COLLATE "pg_catalog"."default",
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4 DEFAULT 0,
  "update_time" timestamptz(6),
  "update_uid" int4
)
;

-- ----------------------------
-- Primary Key structure for table loc_storage_type
-- ----------------------------
ALTER TABLE "public"."loc_storage_type" ADD CONSTRAINT "loc_storage_type_pkey" PRIMARY KEY ("loc_storage_type_id");
