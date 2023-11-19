import { HttpClient } from '@angular/common/http';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-shopping-list-dialog',
  templateUrl: './shopping-list-dialog.component.html',
  styleUrls: ['./shopping-list-dialog.component.css'],
})
export class ShoppingListDialogComponent implements OnInit {
  @Input() showPopup: boolean = false;
  @Input() shopper: any;
  @Output() closePopup = new EventEmitter();
  items: any[] = [];
  checkedItem: any[] = [];

  constructor(private dialog: MatDialog, private http: HttpClient) {}

  ngOnInit(): void {
    this.http
      .get<any[]>('https://localhost:7073/Item/' + this.shopper.shopperId)
      .subscribe((data) => {
        this.items = data;
      });
  }
  onClosePopup() {
    this.showPopup = false;
    this.closePopup.emit();
  }
  onCheckboxChange(checked: boolean, item: any) {
    const index = this.checkedItem.indexOf(item);
    if (checked && index === -1) {
      this.checkedItem.push(item);
    } else if (!checked && index !== -1) {
      if (index !== -1) {
        this.checkedItem.splice(index, 1);
      }
    }
  }
  Save() {
    if(this.checkedItem===null){
      alert("You haven't marked the items.")
    }
    else{

    
    this.http
      .post<any>(
        'https://localhost:7073/ShoppingLists?shopperId=' +
          this.shopper.shopperId,
        this.checkedItem
      )
      .subscribe(
        (response) => {
          this.onClosePopup();
          alert('Items successfully added.');
          window.location.reload();
        },
        (error) => {
          console.error('Error occurred:', error);
        }
      );
    }
  }

  isParameterOk(item: any) {
    if (item.quantity == 0) {
      return true;
    } else {
      return false;
    }
  }
}
