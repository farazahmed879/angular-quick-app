import { Component, OnInit, ViewChild, Input } from '@angular/core';
import { CreateGroup } from 'src/app/models/createGroup.model';

@Component({
  selector: 'app-createOrEditGroup.component',
  templateUrl: './createOrEditGroup.component.html',
  styleUrls: ['./createOrEditGroup.component.scss']
})
export class GroupCreateOrEditComponent implements OnInit {
  public group: CreateGroup;
  public isViewOnly: false;

  @ViewChild('f')
  public form;


  constructor() {
  }

  ngOnInit() {
  }


  handleSubmit(){
    
  }

}
