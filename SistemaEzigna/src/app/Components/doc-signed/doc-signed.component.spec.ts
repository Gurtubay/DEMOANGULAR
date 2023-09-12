import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DocSignedComponent } from './doc-signed.component';

describe('DocSignedComponent', () => {
  let component: DocSignedComponent;
  let fixture: ComponentFixture<DocSignedComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DocSignedComponent]
    });
    fixture = TestBed.createComponent(DocSignedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
