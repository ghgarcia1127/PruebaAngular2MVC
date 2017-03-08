import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

/*Components*/
import { ListComponent } from './Components/list.component';

/*Services*/
import { CollectionService } from './Services/collection.service';

/*Routing*/
import { collectionsRouting } from './collections.routing';

@NgModule({
    imports: [collectionsRouting, CommonModule, FormsModule],
    exports: [],
    declarations: [ListComponent],
    providers: [{ provide: "ICollectionService", useClass: CollectionService }]
})
export class CollectionsModule { }