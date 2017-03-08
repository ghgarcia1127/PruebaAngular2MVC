import { Observable } from 'rxjs';
import { Collection } from '../Models/collection.model';

export interface ICollectionService {
    GetAll(): Promise<Collection[]>;
}