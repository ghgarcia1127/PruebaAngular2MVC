import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise'
import { Observable } from 'rxjs';

import { Collection } from '../Models/collection.model';
import { ICollectionService } from './icollection.service';

@Injectable()
export class CollectionService implements ICollectionService {

    private apiUrl = 'services/collections';
    private headers = new Headers({ 'Content-Type': 'application/json' });

    private http: Http;

    constructor(http: Http) {
        this.http = http;
    }
    GetAll() {
        return this.http.get(this.apiUrl).toPromise()
            .then(response=>response.json() as Collection[])
            .catch(this.handleError);
    }
    private handleError(error: any): Promise<any> {
        return Promise.reject(error.message || error);
    }
}