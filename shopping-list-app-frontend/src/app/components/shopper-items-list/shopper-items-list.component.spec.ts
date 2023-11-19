import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShopperItemsListComponent } from './shopper-items-list.component';

describe('ShopperItemsListComponent', () => {
  let component: ShopperItemsListComponent;
  let fixture: ComponentFixture<ShopperItemsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ShopperItemsListComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ShopperItemsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
