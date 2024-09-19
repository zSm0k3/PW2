import { Component, OnInit } from '@angular/core';
import { CursoService } from '../../services/curso.service';

@Component({
  selector: 'app-curso-listar',
  standalone: true,
  imports: [],
  templateUrl: './curso-listar.component.html',
  styleUrl: './curso-listar.component.css'
})
export class CursoListarComponent implements OnInit {
  cursos: any[] = [];

  constructor(private cursoService: CursoService) {}

  ngOnInit(): void {
    this.cursoService.listar().subscribe(dados => {
      this.cursos = dados;
    })
  }
}
