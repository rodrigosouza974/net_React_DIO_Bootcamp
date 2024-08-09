As funções trigonométricas da classe `System.Math` em C# permitem calcular valores relacionados a ângulos e triângulos. Aqui estão as principais funções trigonométricas disponíveis:

### 1. Seno
- **Método**: `Math.Sin(double angle)`
- **Descrição**: Calcula o seno do ângulo especificado em radianos.
- **Exemplo**:
  ```csharp
  double sin = Math.Sin(Math.PI / 2); // Resultado: 1
  ```

### 2. Cosseno
- **Método**: `Math.Cos(double angle)`
- **Descrição**: Calcula o cosseno do ângulo especificado em radianos.
- **Exemplo**:
  ```csharp
  double cos = Math.Cos(0); // Resultado: 1
  ```

### 3. Tangente
- **Método**: `Math.Tan(double angle)`
- **Descrição**: Calcula a tangente do ângulo especificado em radianos.
- **Exemplo**:
  ```csharp
  double tan = Math.Tan(Math.PI / 4); // Resultado: 1
  ```

### 4. Arcoseno
- **Método**: `Math.Asin(double value)`
- **Descrição**: Calcula o arcoseno (inverso do seno) do valor especificado. O resultado é um ângulo em radianos.
- **Exemplo**:
  ```csharp
  double asin = Math.Asin(1); // Resultado: π/2 (ou 1.5707963267948966 em radianos)
  ```

### 5. Arcocosseno
- **Método**: `Math.Acos(double value)`
- **Descrição**: Calcula o arcocosseno (inverso do cosseno) do valor especificado. O resultado é um ângulo em radianos.
- **Exemplo**:
  ```csharp
  double acos = Math.Acos(1); // Resultado: 0
  ```

### 6. Arcotangente
- **Método**: `Math.Atan(double value)`
- **Descrição**: Calcula a arcotangente (inverso da tangente) do valor especificado. O resultado é um ângulo em radianos.
- **Exemplo**:
  ```csharp
  double atan = Math.Atan(1); // Resultado: π/4 (ou 0.7853981633974483 em radianos)
  ```

### 7. Arcotangente de Dois Parâmetros
- **Método**: `Math.Atan2(double y, double x)`
- **Descrição**: Calcula a arcotangente de dois valores. O resultado é o ângulo em radianos entre o eixo x e o ponto (x, y).
- **Exemplo**:
  ```csharp
  double atan2 = Math.Atan2(1, 1); // Resultado: π/4 (ou 0.7853981633974483 em radianos)
  ```

### 8. Conversão de Graus para Radianos
- **Método**: `Math.PI / 180`
- **Descrição**: Converte um ângulo de graus para radianos.
- **Exemplo**:
  ```csharp
  double angleInDegrees = 180;
  double angleInRadians = angleInDegrees * (Math.PI / 180); // Resultado: π (ou 3.141592653589793)
  ```

### 9. Conversão de Radianos para Graus
- **Método**: `180 / Math.PI`
- **Descrição**: Converte um ângulo de radianos para graus.
- **Exemplo**:
  ```csharp
  double angleInRadians = Math.PI;
  double angleInDegrees = angleInRadians * (180 / Math.PI); // Resultado: 180
  ```

### Exemplo Completo de Uso
Aqui está um exemplo completo que demonstra o uso das funções trigonométricas em um programa C#:

```csharp
using System;

public class TrigonometricFunctionsExample
{
    public static void Main(string[] args)
    {
        double angle = Math.PI / 4; // 45 graus em radianos

        double sin = Math.Sin(angle);
        double cos = Math.Cos(angle);
        double tan = Math.Tan(angle);

        double asin = Math.Asin(1); // π/2
        double acos = Math.Acos(1); // 0
        double atan = Math.Atan(1); // π/4
        double atan2 = Math.Atan2(1, 1); // π/4

        double degrees = 180;
        double radians = degrees * (Math.PI / 180); // Convertendo graus para radianos

        Console.WriteLine($"Seno de {angle} radianos: {sin}");
        Console.WriteLine($"Cosseno de {angle} radianos: {cos}");
        Console.WriteLine($"Tangente de {angle} radianos: {tan}");
        Console.WriteLine($"Arcoseno de 1: {asin} radianos");
        Console.WriteLine($"Arcocosseno de 1: {acos} radianos");
        Console.WriteLine($"Arcotangente de 1: {atan} radianos");
        Console.WriteLine($"Arcotangente de (1, 1): {atan2} radianos");
        Console.WriteLine($"{degrees} graus em radianos: {radians}");
    }
}
```

Este exemplo cobre as principais funções trigonométricas e suas aplicações, ilustrando como calcular ângulos, conversões entre graus e radianos, e como usar os métodos fornecidos pela classe `System.Math`.