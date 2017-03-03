"use strict";
var router_1 = require('@angular/router');
var common_1 = require('@angular/common');
var list_component_1 = require('../Collections/Components/list.component');
var appRoutes = [
    { path: '', component: list_component_1.ListComponent }
];
exports.appRoutingProviders = [
    { provide: common_1.APP_BASE_HREF, useValue: '/' }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map