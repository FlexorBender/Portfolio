program Record files;
uses crt;
      
type  Credit=record
         bank:string[10];
         summ:integer;
         payment:integer; 
         delay:char; 
         end;
         
      mass=array[1..3] of Credit;
      
      TBorrower=record
         name: string[35];
         surname:string[15];
         credits:mass;
         end;
       
      FBorrower = file of TBorrower;
      
procedure task;
begin
  writeln('В файле хранится информация о кредитных историях: фамилия, имя, отчество заемщика,');
  writeln('кредитная история: список не более чем из 3 кредитов, с указанием названия банка,');
  writeln('суммы кредита, ежемесячного платежа и отметки об имеющейся просрочке.');
  writeln('В новый файл переписать информацию о заемщиках, взявших кредит в заданном банке.');
  writeln('Вывести в текстовый файл фамилии заемщиков, у которых имеется просрочка хотя бы по одному платежу.');
  readln;
end;

procedure text_m1;
begin
  writeln('Меню:');
  writeln('1. Задание.');
  writeln('2. Создать файл записей.');
  writeln('3. Работа с файлом записей');
  writeln('4. Создать файл с записями клиентов с заданным именем банка.');
  writeln('5. Создать файл со списком заемщиков с просрочками.');
  writeln('6. Просмотр текстового файла.');
  writeln('7. Удалить файл.');
  writeln('0. Выход из программы.');
  writeln(' ');
end;

procedure text_m2;
begin
   writeln;
   writeln('    1)Добавить запись');
   writeln('    2)Удалить запись');
   writeln('    3)Редактировать запись');
   writeln('    0)Выйти в главное меню');
end;

procedure show_rec_file(var f1:FBorrower);
var bor:TBorrower;
    i,j:integer;

begin
  reset(f1);
  i:=1;
  clrscr;
  writeln('№':4, 'ФИО':35, 'Банк':10, 'Сумма':10, 'Платеж':8, 'Просрочка':10);
  writeln;
  while not eof(f1) do begin
    read(f1,bor);
    write(i:4, bor.name:20, bor.surname:15);
    writeln(bor.credits[1].bank:10, bor.credits[1].summ:10, bor.credits[1].payment:8, bor.credits[1].delay:10);
    for j:=2 to 3 do
      if bor.credits[j].bank<>'' then
      writeln(' ':39, bor.credits[j].bank:10, bor.credits[j].summ:10, bor.credits[j].payment:8, bor.credits[j].delay:10);
      inc(i);
      writeln;
  end;
  close(f1);
end;

procedure input_rec(var bor:TBorrower);
var n,i,e:integer;
    s:char;
    s1:string;
begin
   writeln;
   write('Фамилия заемщика: ');
   readln(bor.surname);
   write('Имя и Отчество заемщика: ');
   readln(bor.name);
   write('Введите количество кредитов заемщика: ');
   readln(n);
   for i:=1 to 3 do begin
      if i<=n then begin
      
         write('Банк: '); 
         readln(bor.credits[i].bank);            
                  
         bor.credits[i].summ:=0;
         while bor.credits[i].summ=0 do begin
            write('Сумма: '); 
            readln(s1);
            val(s1,bor.credits[i].summ,e);
         end;
         
         bor.credits[i].payment:=0;
         while bor.credits[i].payment=0 do begin
            write('Ежемесячный платеж: '); 
            readln(s1);
            val(s1,bor.credits[i].payment,e);
         end;
         write('Просрочка: '); readln(s);
         if (s='+') or (s='-') then bor.credits[i].delay:=s
         else write('Значение не допустимо, введите + или -');
         writeln;
      end      
      else begin
         bor.credits[i].bank:='';
         bor.credits[i].summ:=0;
         bor.credits[i].payment:=0;
         bor.credits[i].delay:=' ';
      end;
   end;
end;

procedure add_rec(var f1:FBorrower; bor:TBorrower);
begin
   reset(f1);
   seek(f1,filesize(f1));
   write(f1,bor);
   close(f1);
end;

procedure del_rec(var f1:FBorrower; n:integer);
var bor:TBorrower;
begin
   reset(f1);
   if (n<>(filesize(f1)-1)) then begin
      seek(f1,filesize(f1)-1);
      read(f1,bor);
      seek(f1,n);
      write(f1,bor);
   end;
   seek(f1,filesize(f1)-1);
   truncate(f1);
   close(f1);
end;

procedure change_rec(var f1:FBorrower; n,k,z:integer);
var bor:TBorrower;
    c:integer;
    s:string;
    s1:char;
    
begin
  reset(f1);    
  seek(f1, n);
  read(f1,bor);
    case k of
      
      1: begin
          write('Введите фамилию заемщика: '); readln(bor.surname);
          seek(f1,n);
          write(f1,bor);
         end;
    
      2: begin
          write('Введите имя, отчество заемщика: '); readln(bor.name);
          seek(f1,n);
          write(f1,bor);
         end;
            
      3: begin      
          write('Введите банк: '); readln(bor.credits[z].bank);
          seek(f1,n);
          write(f1,bor);
         end;
      
      4: begin
          bor.credits[z].summ:=0;
          while bor.credits[z].summ=0 do begin
            write('Введите сумму '); 
            readln(s);
            val(s,bor.credits[z].summ,c);
            if c=0 then val(s,bor.credits[z].summ,c)
            else writeln('Значение не может быть использовано, введите еще раз');      
          end;
          seek(f1,n);
          write(f1,bor);
      end;
      
      5: begin
          bor.credits[z].payment:=0;
          while bor.credits[z].payment=0 do begin
            write('Введите платеж '); 
            readln(s);
            val(s,bor.credits[z].payment,c);
            if c=0 then val(s,bor.credits[z].payment,c)
            else writeln('Значение не может быть использовано, введите еще раз'); 
          end;
          seek(f1,n);
          write(f1,bor);
        end;
        
      6: begin
          bor.credits[z].delay:=' ';
          while bor.credits[z].delay=' ' do begin
            write('Просрочка (+/-) '); 
            readln(s1);
            if (s1='+') or (s1='-') then bor.credits[z].delay:=s1
            else writeln('Значение не может быть использовано, введите еще раз'); 
          end;
          seek(f1,n);
          write(f1,bor);
      end;
    end;
  close(f1);
end;

procedure get_biggeg(var f1:FBorrower; var f2:FBorrower; bankname:string);    //замена
var s1:integer; 
    i:integer;
    bor:TBorrower;
    wrd:string;
begin
   reset(f1);
   reset(f2);
   
   while not eof(f1) do begin
      read(f1,bor);
      for i:=1 to 3 do begin
        if bor.credits[i].bank = bankname then begin
          write(f2, bor);
        end;
      end;
   end;
   close(f1);
   close(f2);
end;

procedure get_no_delay(var f1:FBorrower; var f3:text);
var bor:TBorrower;
    i,k,ki:integer;

begin
   reset(f1);
   rewrite(f3);
   while not eof(f1) do begin
      read(f1,bor);
      for i:=1 to 3 do begin
         if bor.credits[i].delay='+' then writeln(f3, bor.surname: 20, bor.credits[i].delay: 20);
      end;
   end;
   close(f1);
   close(f3);
end;

procedure show_file3(f3:text);
var st:string;
begin
   clrscr;
   writeln('Список заемщиков, у которых есть просрочка по одному и более кредитов:');
   writeln;
   reset(f3);
   while not eof(f3) do begin
      readln(f3,st);
      writeln(st);
   end;
   close(f3);
end;

var   bor:TBorrower;
      f1, f2:FBorrower;
      f3:text;
      num1, num2, n,k,z,c:integer;
      name1, name2, name3,s:string;
      s1:string;
      e:integer;
      bankname:string;

begin
   repeat begin
      clrscr;
      text_m1;
      num1:=10;
      while num1=10 do begin
         write('Выберите действие: '); 
         readln(s1);
         val(s1,num1,e);         
      end;
      
      case num1 of
         1: begin
               clrscr;
               task;
            end;
            
         2: begin
               clrscr;
               write('Введите имя нового исходного файла: '); 
               readln(name1);
               if not FileExists(name1) then begin
                  assign(f1,name1);
                  rewrite(f1);
                  close(f1);
                  write('Файл успешно создан, нажмите ENTER, чтобы вернуться в меню.'); 
                  readln;
               end
               else begin
                  writeln('Файл с таким именем уже существует! Нажмите ENTER, чтобы вернуться в меню.'); 
                  readln;
               end;
               end;
               
         3: begin               
                  clrscr;
                  write('Введите имя файла, с которым хотите работать: '); readln(name1);
                  if not FileExists(name1) then begin
                     writeln('Файл с таким именем не существует.');
                     readln;
                  end
                  else begin
                     assign(f1,name1);
                     repeat begin
                     clrscr;
                     show_rec_file(f1);
                     text_m2;
                     num2:=10;
                     while num2=10 do begin
                        write('Выберите действие: ');
                        readln(s1);
                        val(s1,num2,e);
                     end;
                     
                     case num2 of
                        1: begin
                              write('Создание новой записи в файле ', name1);
                              input_rec(bor);
                              add_rec(f1, bor);
                           end;
                        
                        2: begin                             
                             n:=-1;
                             while n=-1 do begin
                              write('Введите номер записи, которую хотите удалить из файла: '); 
                              readln(s1);
                              val(s1,n,e);
                             end;
                             dec(n);
                             del_rec(f1, n);
                           end;
                           
                        3: begin 
                              writeln;
                              n:=-1;
                              while n=-1 do begin
                                 write('Введите номер изменяемой записи: '); 
                                 readln(s1);
                                 val(s1,n,e);
                              end;
                              dec(n);                              
                              k:=7;
                              while k=7 do begin
                                 write('Изменить: Фамилия - 1, Имя и Отчество - 2, банк - 3, сумму - 4, платеж - 5, просрочку - 6, выйти - 0'); readln(s);
                                 val(s,k,c);                                 
                              end;
                              if k<>1 then begin
                                 z:=11;
                                 while z=11 do begin
                                    write('Введите номер кредита: '); readln(s);
                                    val(s,z,c);
                                 end;
                              end;
                              change_rec(f1, n,k,z);              
                           end;                     
                     end;
                     end;
                   until num2=0;
                  end;
               end;
            
            4: begin
                  write('Введите имя исходного файла записей: '); readln(name1);
                  if fileExists(name1) then begin
                     assign(f1,name1);
                     write('Ведите имя результирующего файла записей: '); readln(name2);
                     if not fileExists(name2) then begin
                        assign(f2,name2);
                        rewrite(f2);
                        close(f2);                        
                        writeln('Введите имя банка: ');
                        readln(bankname);
                        get_biggeg(f1, f2, bankname);
                        writeln('Имя банка = ',bankname,'. Файл с именем ',name2,' успешно создан.');
                        write('Вы сможете посмотреть его содержимое в режиме работы с файлом.');
                        readln;
                     end
                     else begin
                        write('Файл записей с таким именем уже существует!'); readln;
                     end;
                  end
                  else begin
                     write('Файл записей с таким именем не существует!'); readln;
                  end;
               end;
            
            5: begin
               
               write('Введите имя исходного файла записей: '); readln(name1);
               if fileExists(name1) then begin
                  assign(f1,name1);
                  write('Введите имя результируеющего текстового файла: '); readln(name3);
                  if not fileExists(name3) then begin
                     assign(f3,name3);
                     rewrite(f3);
                     close(f3);
                     get_no_delay(f1, f3);
                     writeln('Файл с именем ',name3,' успешно создан.');
                     write('Вы сможете посмотреть его содержимое в режиме просмотра текстовых файлов.');
                     readln;
                  end
                  else begin
                     write('Текстовый файл с таким именем уже существует!');
                  end;
               end
               else begin
                  write('Файл записей с таким именем не существует!'); readln;
               end;
               end;
            
            6: begin
                  write('Введите имя текстового файла для просмотра: ');
                  readln(name3);
                  if fileexists(name3) then begin
                     assign(f3,name3);
                     show_file3(f3);
                     readln;
                  end
                  else begin
                     write('Файл с таким именем не существует!');
                     readln;
                  end;
               end;
            
            7: begin
                  write('Введите имя удаляемого файла: '); readln(name1);
                  if not FileExists(name1) then writeln('Файл с таким именем не существует')
                  else begin
                  assign(f1,name1);
                  erase(f1);
                  writeln('Файл успешно удален, нажмите ENTER, чтобы продолжить');
                  readln;
                  end;                  
               end;                          
         
         end; 
      end;
      
   until num1=0;
end.