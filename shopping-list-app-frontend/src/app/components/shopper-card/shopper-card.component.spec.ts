import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShopperCardComponent } from './shopper-card.component';

describe('ShopperCardComponent', () => {
  let component: ShopperCardComponent;
  let fixture: ComponentFixture<ShopperCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShopperCardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShopperCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
