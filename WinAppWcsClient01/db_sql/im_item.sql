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

 Date: 18/08/2020 14:17:58
*/


-- ----------------------------
-- Table structure for im_item
-- ----------------------------
DROP TABLE IF EXISTS "public"."im_item";
CREATE TABLE "public"."im_item" (
  "im_item_id" int4 NOT NULL DEFAULT nextval('im_item_id_seq'::regclass),
  "product_no" int4 NOT NULL,
  "item_no" varchar(50) COLLATE "pg_catalog"."default" NOT NULL,
  "item_desc" varchar(100) COLLATE "pg_catalog"."default",
  "customer_id" int4,
  "remark_desc" varchar(50) COLLATE "pg_catalog"."default",
  "void" int4,
  "update_time" timestamptz(6),
  "update_uid" int4
)
;

-- ----------------------------
-- Uniques structure for table im_item
-- ----------------------------
ALTER TABLE "public"."im_item" ADD CONSTRAINT "uk_product_no" UNIQUE ("product_no");

-- ----------------------------
-- Primary Key structure for table im_item
-- ----------------------------
ALTER TABLE "public"."im_item" ADD CONSTRAINT "im_item_pkey" PRIMARY KEY ("im_item_id");
