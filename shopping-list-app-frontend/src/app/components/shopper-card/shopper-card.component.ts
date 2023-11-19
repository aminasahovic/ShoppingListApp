import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-shopper-card',
  templateUrl: './shopper-card.component.html',
  styleUrls: ['./shopper-card.component.css'],
})
export class ShopperCardComponent implements OnInit {
  @Input() shopper: any;
  dialog: any;
  @Input() showPopup: boolean = false;
  @Input() showList: boolean = false;

  constructor() {}

  ngOnInit(): void {}

  closePopup() {
    this.showPopup = false;
  }
  openDialog() {
    this.showPopup = true;
  }
  viewList() {
    this.showList = true;
  }
  closeList() {
    this.showList = false;
  }
}
