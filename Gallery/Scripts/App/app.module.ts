/*Módulos externos*/
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { routing, appRoutingProviders } from './app.routing';
import './rxjs-extensions';


/*Módulos propios*/
import { CollectionsModule } from './Collections/collections.module';

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
export class AppModule { }

