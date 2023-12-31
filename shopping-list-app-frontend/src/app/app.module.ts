// import 'tslib';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatCardModule } from '@angular/material/card';
import { ShopperCardComponent } from './components/shopper-card/shopper-card.component';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { ContainerComponent } from './components/container/container.component';
import { HttpClientModule } from '@angular/common/http';
import { ShoppingListDialogComponent } from './components/shopping-list-dialog/shopping-list-dialog.component';
import {MatCheckboxModule} from '@angular/material/checkbox';
import { ShoppingItemsViewComponent } from "./components/shopping-items-view/shopping-items-view.component";

@NgModule({
    declarations: [
        AppComponent,
        ShopperCardComponent,
        ContainerComponent,
        ShoppingListDialogComponent,
    ],
    providers: [],
    bootstrap: [AppComponent],
    imports: [
        BrowserModule,
        AppRoutingModule,
        MatCardModule,
        MatButtonModule,
        MatIconModule,
        HttpClientModule,
        MatCheckboxModule,
        ShoppingItemsViewComponent
    ]
})
export class AppModule {}
