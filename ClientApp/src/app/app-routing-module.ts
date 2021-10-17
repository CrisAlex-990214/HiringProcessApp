import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { PostulationListComponent } from "./postulation-list/postulation-list.component";
import { PostulationComponent } from "./postulation/postulation.component";

const routes: Routes = [
    { path: "", component: PostulationListComponent },
    { path: "postulation/:id", component: PostulationComponent }
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}