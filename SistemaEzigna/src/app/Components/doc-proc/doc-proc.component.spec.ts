import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DocProcComponent } from './doc-proc.component';

describe('DocProcComponent', () => {
  let component: DocProcComponent;
  let fixture: ComponentFixture<DocProcComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DocProcComponent]
    });
    fixture = TestBed.createComponent(DocProcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
