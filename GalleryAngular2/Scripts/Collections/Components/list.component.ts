import { Component, OnInit, Input, Inject } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Collection } from '../Models/Collection';
import { ICollectionService } from '../Services/Def/collection.service';

@Component({
    selector: 'collection-list',
    templateUrl: '../Scripts/Collections/Templates/index.html',
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
        this.collectionService.getAll().then(
            collections => this.collections = collections);
    }

    delete(id: string) {
        this.collectionService.delete(id).catch(reason => alert("Ups: " + reason));
    }

}