import { Component } from '@angular/core';
import { Order } from './Order';
import { OrderService } from './order.service';
import * as _ from "lodash";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'BorusanUI';
  orders: Order[] = [];
  selectedOrderNo: string;
  showAlert: boolean = false;

  constructor(private orderService: OrderService) {

  }

  ngOnInit(): void {
    this.selectedOrderNo = "";
    this.getMovie();
  }

  getMovie(): void {
    this.orderService.getData()
      .subscribe(response => {
        if (!_.isNil(response) && response.isSuccess && !_.isEmpty(response.data)) {
          this.orders = response.data;
        } else {

        }
      });
  }

  changeOrder(e) {
    if (!_.isNil(e) && !_.isNil(e.target) && !_.isEmpty(e.target.value)) {
      this.selectedOrderNo = e.target.value;
      this.showAlert = false;
    }
  }

  onSave(){
    if (!_.isEmpty(this.selectedOrderNo)) {
      this.showAlert = false;
      let currentOrder: Order = _.find(this.orders, o => o.customerOrderNo == this.selectedOrderNo);
    } else {
      this.showAlert = true;
    }

  }

}
