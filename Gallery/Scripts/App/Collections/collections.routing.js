"use strict";
var router_1 = require('@angular/router');
var list_component_1 = require('./Components/list.component');
var collectionsRouter = [
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
                component: list_component_1.ListComponent
            }
        ]
    }
];
exports.collectionsRouting = router_1.RouterModule.forChild(collectionsRouter);
//# sourceMappingURL=collections.routing.js.map