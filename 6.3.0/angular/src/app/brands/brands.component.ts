import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { BrandDto, BrandServiceProxy, GetAllBrandsOutputDto } from '@shared/service-proxies/service-proxies';
import { Table } from 'primeng/table';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-brands',
  templateUrl: './brands.component.html',
  styleUrls: ['./brands.component.css']
})
export class BrandsComponent extends PagedListingComponentBase<BrandDto> {  
  @ViewChild('dataTable') dataTable: Table;
  
  brands: BrandDto[] = [];
  filterText: string;
  first = 0;
  rows = 10;

  constructor(injector: Injector,
    private _brandsService: BrandServiceProxy
  ) {
    super(injector);
  }

  protected list(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
    this._brandsService
      .getAll(this.filterText, request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: GetAllBrandsOutputDto) => {
        this.brands = result.items;
        //this.showPaging(result, pageNumber);
      });
  }
  protected delete(entity: BrandDto): void {
    throw new Error('Method not implemented.');
  }

}
