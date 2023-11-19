import { Component, EventEmitter, Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-shopping-items-view',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './shopping-items-view.component.html',
  styleUrl: './shopping-items-view.component.css',
})
export class ShoppingItemsViewComponent {
  @Input() showView: boolean = false;
  @Input() shopper: any;
  @Output() closeView = new EventEmitter();
  items: any[] = [];

  constructor(private http: HttpClient) {}
  loadData() {
    this.http
      .get<any[]>(
        'https://localhost:7073/ShoppingLists/' + this.shopper.shopperId
      )
      .subscribe((data) => {
        this.items = data;
      });
  }
  ngOnInit(): void {
    this.loadData();
  }

  onCloseView() {
    this.showView = false;
    this.closeView.emit();
  }

  Delete(item: any) {
    this.http
      .delete<any[]>(
        'https://localhost:7073/ShoppingLists/' + item.shoppingListsId
      )
      .subscribe(
        () => {
          console.log('Sadržaj je uspješno obrisan');
          this.loadData();
          location.reload();
        },
        (error) => {
          console.error('Greška prilikom brisanja:', error);
        }
      );
  }
}
