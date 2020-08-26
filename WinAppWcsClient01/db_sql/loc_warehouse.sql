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

 Date: 18/08/2020 14:32:12
*/


-- ----------------------------
-- Table structure for loc_warehouse
-- ----------------------------
DROP TABLE IF EXISTS "public"."loc_warehouse";
CREATE TABLE "public"."loc_warehouse" (
  "loc_warehouse_id" int4 NOT NULL,
  "warehouse_id" int4 NOT NULL,
  "warehouse_desc" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4 DEFAULT 0,
  "update_time" timestamptz(6),
  "update_uid" int4
)
;

-- ----------------------------
-- Primary Key structure for table loc_warehouse
-- ----------------------------
ALTER TABLE "public"."loc_warehouse" ADD CONSTRAINT "loc_warehouse_pkey" PRIMARY KEY ("loc_warehouse_id");
