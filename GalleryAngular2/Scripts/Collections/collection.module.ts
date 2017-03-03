
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

/*components*/
import { ListComponent } from './Components/list.component';
import { DetailComponent } from './Components/detail.component';

/*Services*/
import { CollectionService } from './Services/src/collection.service';

/*Routing*/
import { CollectionRouting } from './collection.routing';

@NgModule({
    imports: [CollectionRouting, CommonModule, FormsModule],
    exports: [],
    declarations: [ListComponent, DetailComponent],
    providers: [{ provide: "ICollectionService", useClass: CollectionService }]
})
export class CollectionsModule { }