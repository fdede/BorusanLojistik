import { AmountType } from "./AmountType";
import { Material } from "./Material";
import { OrderStatus } from "./OrderStatus";
import { WeightUnit } from "./WeightUnit";

export class Order {
  customerOrderNo: string;
  fromAddress: string;
  toAddress: string;
  amount: number;
  amountTypeDto: AmountType;
  weight: number;
  weightUnitDto: WeightUnit;
  materialDto: Material;
  note: string;
  orderStatusDto: OrderStatus;
}
