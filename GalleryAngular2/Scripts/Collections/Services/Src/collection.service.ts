import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise'
import { Observable } from 'rxjs';

import { Collection } from '../../Models/collection';
import { ICollectionService } from '../Def/collection.service';


@Injectable()
export class CollectionService implements ICollectionService {

    private collectionsUrl = 'api/collection';
    private headers = new Headers({ 'Content-Type': 'application/json' });

    private http: Http;
    constructor(http: Http) {
        this.http = http;
    }

    getAll(): Promise<Collection[]> {
        var data = this.http.get(this.collectionsUrl)
            .toPromise()
            .then(response =>
                response.json() as Collection[])
            .catch(this.handleError);
        return data;
    }

    get(id: string): Promise<Collection> {
        return this.getAll().then(collections => collections.find(collection => collection.Id === id));
    }

    update(collection: Collection): Promise<Collection> {
        const url = `${this.collectionsUrl}/${collection.Id}`;
        return this.http
            .put(url, JSON.stringify(collection), { headers: this.headers })
            .toPromise()
            .then(() => collection)
            .catch(this.handleError);
    }

    create(collection: Collection): Promise<Collection> {
        collection.Id = null;
        return this.http
            .post(this.collectionsUrl, JSON.stringify(collection), { headers: this.headers })
            .toPromise()
            .then(res => res.json().data)
            .catch(this.handleError);
    }

    delete(id: string): Promise<void> {
        let url = `${this.collectionsUrl}/delete/${id}`;
        return this.http.delete(url, { headers: this.headers })
            .toPromise()
            .then(() => null)
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error); // for demo purposes only
        return Promise.reject(error.message || error);
    }
}