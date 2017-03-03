
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CollectionService } from '../Collections/Services/Src/collection.service';
import { APP_BASE_HREF } from '@angular/common';
import { ListComponent } from '../Collections/Components/list.component';


const appRoutes: Routes = [
    { path: '', component: ListComponent }
];

export const appRoutingProviders: any[] = [
    { provide: APP_BASE_HREF, useValue: '/' }
];


export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);