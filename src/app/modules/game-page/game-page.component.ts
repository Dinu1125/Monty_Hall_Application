import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Subscriber, Subscription } from 'rxjs';
import { ApiService } from 'src/app/core/services/api.service';

@Component({
  selector: 'app-game-page',
  templateUrl: './game-page.component.html',
  styleUrls: ['./game-page.component.scss']
})
export class GamePageComponent implements OnInit {

  constructor(private apiServise: ApiService) { }

  gameForm!: FormGroup
  result: any;
  _subscribe: Subscription = new Subscription();
  ngOnInit() {
    this.generateForm();
  }

  generateForm(){
    this.gameForm = new FormGroup({
      numSimulations: new FormControl('', Validators.required),
      changeDoor: new FormControl(false)
    })
  }

  playGame(){
    let data = this.gameForm.value;
    this._subscribe.add(
      this.apiServise.get(data).subscribe((result: any) => {
        this.result = result;
      })
    )

  }
}
