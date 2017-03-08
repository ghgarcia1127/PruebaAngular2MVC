import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { APP_BASE_HREF } from '@angular/common';


const appRoutes: Routes = [
];

export const appRoutingProviders: any[] = [
    { provide: APP_BASE_HREF, useValue: '/' }
];


export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);
