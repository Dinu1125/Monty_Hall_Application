import { NgModule } from "@angular/core";
import { GamePageComponent } from "./game-page.component";
import { CommonModule } from "@angular/common";
import { RouterModule } from "@angular/router";
import { ReactiveFormsModule } from "@angular/forms";

@NgModule
({
  declarations:
  [
    GamePageComponent
  ],
  imports:
  [
    CommonModule,
    RouterModule.forChild([
      {
        path: '',
        component: GamePageComponent,
      },
    ]),
    ReactiveFormsModule
  ],
  exports: [RouterModule],
})

export class GamePageModule { }
