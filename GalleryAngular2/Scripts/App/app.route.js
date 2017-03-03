"use strict";
var router_1 = require('@angular/router');
var collection_service_1 = require('../Collections/Services/Src/collection.service');
var common_1 = require('@angular/common');
var collection_component_1 = require('../Collections/collection.component');
var appRoutes = [
    { path: '', component: collection_component_1.CollectionComponent }
];
exports.appRoutingProviders = [{ provide: "ICollectionService", useClass: collection_service_1.CollectionService },
    { provide: common_1.APP_BASE_HREF, useValue: '/' }];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.route.js.map