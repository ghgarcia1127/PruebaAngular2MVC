import { Collection } from '../../Models/Collection';
import { Observable } from 'rxjs';

export interface ICollectionService {
    getAll(): Promise<Collection[]>;
    get(id: string): Promise<Collection>;
    update(patient: Collection): Promise<Collection>;
    create(patient: Collection): Promise<Collection>;
    delete(id: string): Promise<void>;
}