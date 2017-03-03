import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ListComponent } from './Components/list.component';
import { DetailComponent } from './Components/detail.component';

const collectionRoutes: Routes = [
    {
        path: '',
        redirectTo: '/Collections',
        pathMatch: 'full'
    },
    {
        path: 'Collections',
        children: [
            {
                path: '',
                component: ListComponent,

            },
            {
                path: ':id',
                component: DetailComponent

            }
        ]
    }
];

export const CollectionRouting: ModuleWithProviders = RouterModule.forChild(collectionRoutes);