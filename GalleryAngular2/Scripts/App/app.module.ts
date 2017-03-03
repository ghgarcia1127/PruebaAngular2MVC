import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { routing, appRoutingProviders } from './app.routing';
import './rxjs-extensions';

/*Modulos*/
import { CollectionsModule } from '../Collections/collection.module';

/*Componentes*/
import { AppComponent } from './app.component';

@NgModule({
    imports: [BrowserModule,
        FormsModule,
        HttpModule,
        routing,
        CollectionsModule],
    declarations: [AppComponent],
    bootstrap: [AppComponent],
    providers: [appRoutingProviders]
})

export class AppModule {
    Title: string;
    constructor() {
        this.Title = "Collections";
    }
}