import { Component, OnInit, Input, Inject } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';

import { ICollectionService } from '../Services/icollection.service';
import { Collection } from '../Models/collection.model';

@Component({
    selector: 'collection-list',
    template: `<div class="header">
                    <h4 class="title">&nbsp;&nbsp; Collections</h4>
                </div>
                <div class="content">    
                    <ul class="list-group" >
                        <li class="list-group-item" *ngFor="let collection of collections">
                            {{collection.Id}}-{{collection.Name}}
                        </li>
                    </ul>
                </div>`,
})

export class ListComponent implements OnInit {
    collections: Collection[];

    private collectionService: ICollectionService;
    private router: Router;
    private route: ActivatedRoute;
    constructor( @Inject("ICollectionService") collectionService: ICollectionService, router: Router, route: ActivatedRoute) {
        this.collectionService = collectionService;
        this.router = router;
        this.route = route;
    }

    ngOnInit() {
        this.route.params.forEach((params: Params) => {
            this.getAll();
        });
    }

    getAll() {
        this.collectionService.GetAll().then(collections => this.collections = collections);
    }


}