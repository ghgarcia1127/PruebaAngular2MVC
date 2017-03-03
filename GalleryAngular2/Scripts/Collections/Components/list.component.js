"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
var core_1 = require('@angular/core');
var router_1 = require('@angular/router');
var ListComponent = (function () {
    function ListComponent(collectionService, router, route) {
        this.collectionService = collectionService;
        this.router = router;
        this.route = route;
    }
    ListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.params.forEach(function (params) {
            _this.getAll();
        });
    };
    ListComponent.prototype.getAll = function () {
        var _this = this;
        this.collectionService.getAll().then(function (collections) { return _this.collections = collections; });
    };
    ListComponent.prototype.delete = function (id) {
        this.collectionService.delete(id).catch(function (reason) { return alert("Ups: " + reason); });
    };
    ListComponent = __decorate([
        core_1.Component({
            selector: 'collection-list',
            templateUrl: '../Scripts/Collections/Templates/index.html',
        }),
        __param(0, core_1.Inject("ICollectionService")), 
        __metadata('design:paramtypes', [Object, router_1.Router, router_1.ActivatedRoute])
    ], ListComponent);
    return ListComponent;
}());
exports.ListComponent = ListComponent;
//# sourceMappingURL=list.component.js.map