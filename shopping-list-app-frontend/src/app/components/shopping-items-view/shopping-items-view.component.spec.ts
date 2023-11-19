import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShoppingItemsViewComponent } from './shopping-items-view.component';

describe('ShoppingItemsViewComponent', () => {
  let component: ShoppingItemsViewComponent;
  let fixture: ComponentFixture<ShoppingItemsViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ShoppingItemsViewComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ShoppingItemsViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
