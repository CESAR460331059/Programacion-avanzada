#include <iostream>
#include <string>
using namespace std;

// Crear un registro que alamacene los datos de 5 estudiantes

struct reg_estudiantes 
{
    string nombre,carrera,semestre;
    float promedio;

}estudiante [5];



int main()  
{
    int i;
    //registro de alumnos 
    for(i=0;i<5;i++)
    {
        cout <<"ingresa el nombre del estudiante" <<endl;
        cin >>estudiante[i].nombre;

        cout << "ingresa la carrera del estudiante" <<endl;
        cin >>estudiante[i].carrera;

        cout << "ingresa la semestre del estudiante" <<endl;
        cin >>estudiante[i].semestre;

        cout << "ingresa la promedio del estudiante" <<endl;
        cin >>estudiante[i].promedio;
    }

    //Mostrar datos de los alumnos inscritos 
     cout <<"Alumnos inscritos" <<endl;
    for (i=0;i<5;i++)
    {
        cout<<"Nombre:"<<estudiante[i].nombre<<endl;
        cout<<"Carrera:"<<estudiante[i].carrera<<endl;
        cout<<"Semestre actual:"<<estudiante[i].semestre<<endl;
        cout<<"Promedio:"<<estudiante[i].promedio<<endl;
        cout<<"______________________________________________"<<endl;

    }
    
return 0;

}
