import { Component, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-todo-list',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: ` <p>Todo List Going Here</p> `,
  styles: ``,
})
export class TodoListComponent {}
