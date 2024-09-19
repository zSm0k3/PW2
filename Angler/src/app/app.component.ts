import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CursoListarComponent } from "./components/curso-listar/curso-listar.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterOutlet, CursoListarComponent]
})
export class AppComponent {
  title = 'etec';
}
