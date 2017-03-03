"use strict";
var router_1 = require('@angular/router');
var list_component_1 = require('./Components/list.component');
var detail_component_1 = require('./Components/detail.component');
var collectionRoutes = [
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
                component: list_component_1.ListComponent,
            },
            {
                path: ':id',
                component: detail_component_1.DetailComponent
            }
        ]
    }
];
exports.CollectionRouting = router_1.RouterModule.forChild(collectionRoutes);
//# sourceMappingURL=collection.routing.js.map