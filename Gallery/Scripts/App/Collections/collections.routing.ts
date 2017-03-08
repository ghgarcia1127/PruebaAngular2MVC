import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ListComponent } from './Components/list.component';

const collectionsRouter: Routes = [
    {
        path: '',
        redirectTo: '/collections',
        pathMatch: 'full'
    },
    {
        path: 'collections',
        children: [
            {
                path: '',
                component: ListComponent
            }
        ]
    }
];

export const collectionsRouting : ModuleWithProviders = RouterModule.forChild(collectionsRouter);