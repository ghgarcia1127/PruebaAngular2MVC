import { Component, OnInit, EventEmitter, Input, Output, Inject } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';

import { ICollectionService } from '../Services/Def/collection.service'
import { Collection } from '../Models/collection'


@Component({
    selector: 'collection-detail',
    template: '../Scripts/Collections/Templates/detail.html'
})
export class DetailComponent implements OnInit {

    private collectionService: ICollectionService;
    private router: Router;
    private route: ActivatedRoute;
    constructor( @Inject("ICollectiontService") collectionService: ICollectionService, router: Router, route: ActivatedRoute) {
        this.collectionService = collectionService;
        this.router = router;
        this.route = route;
    }

    ngOnInit() {

    }

}