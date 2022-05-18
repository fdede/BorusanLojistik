import { Order } from "./Order";

export class SearchResult{
  isSuccess: boolean;
  errors: string;
  data: Order[];
}
