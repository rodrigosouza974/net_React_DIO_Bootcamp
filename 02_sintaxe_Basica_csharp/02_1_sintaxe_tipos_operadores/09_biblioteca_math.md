A biblioteca `System.Math` em C# fornece diversos métodos estáticos para realizar operações matemáticas comuns. Aqui estão algumas das principais operações que você pode realizar usando `System.Math`:

### 1. Potência
- **Método**: `Math.Pow(double base, double exponent)`
- **Descrição**: Calcula a base elevada ao expoente.
- **Exemplo**:
  ```csharp
  double result = Math.Pow(2, 3); // Resultado: 8
  ```

### 2. Raiz Quadrada
- **Método**: `Math.Sqrt(double value)`
- **Descrição**: Calcula a raiz quadrada do valor.
- **Exemplo**:
  ```csharp
  double result = Math.Sqrt(16); // Resultado: 4
  ```

### 3. Valor Absoluto
- **Método**: `Math.Abs(double value)`
- **Descrição**: Retorna o valor absoluto do número.
- **Exemplo**:
  ```csharp
  double result = Math.Abs(-5); // Resultado: 5
  ```

### 4. Máximo e Mínimo
- **Método**: `Math.Max(double val1, double val2)` e `Math.Min(double val1, double val2)`
- **Descrição**: Retorna o maior ou menor valor entre dois números.
- **Exemplo**:
  ```csharp
  double max = Math.Max(10, 20); // Resultado: 20
  double min = Math.Min(10, 20); // Resultado: 10
  ```

### 5. Seno, Cosseno e Tangente
- **Método**: `Math.Sin(double angle)`, `Math.Cos(double angle)`, `Math.Tan(double angle)`
- **Descrição**: Calcula o seno, cosseno e tangente do ângulo especificado em radianos.
- **Exemplo**:
  ```csharp
  double sin = Math.Sin(Math.PI / 2); // Resultado: 1
  double cos = Math.Cos(0);           // Resultado: 1
  double tan = Math.Tan(Math.PI / 4); // Resultado: 1
  ```

### 6. Arcoseno, Arcocosseno e Arcotangente
- **Método**: `Math.Asin(double value)`, `Math.Acos(double value)`, `Math.Atan(double value)`
- **Descrição**: Calcula o arcoseno, arcocosseno e arcotangente de um valor.
- **Exemplo**:
  ```csharp
  double asin = Math.Asin(1); // Resultado: π/2
  double acos = Math.Acos(1); // Resultado: 0
  double atan = Math.Atan(1); // Resultado: π/4
  ```

### 7. Logaritmo
- **Método**: `Math.Log(double value)` e `Math.Log10(double value)`
- **Descrição**: Calcula o logaritmo natural (base `e`) e o logaritmo de base 10 do valor.
- **Exemplo**:
  ```csharp
  double log = Math.Log(Math.E);   // Resultado: 1
  double log10 = Math.Log10(100); // Resultado: 2
  ```

### 8. Exponencial
- **Método**: `Math.Exp(double value)`
- **Descrição**: Calcula `e` elevado ao valor especificado.
- **Exemplo**:
  ```csharp
  double exp = Math.Exp(1); // Resultado: e (aproximadamente 2.71828)
  ```

### 9. Arredondamento
- **Método**: `Math.Round(double value)`, `Math.Ceiling(double value)`, `Math.Floor(double value)`
- **Descrição**: Arredonda para o valor mais próximo, para cima, ou para baixo.
- **Exemplo**:
  ```csharp
  double round = Math.Round(3.6);   // Resultado: 4
  double ceiling = Math.Ceiling(3.2); // Resultado: 4
  double floor = Math.Floor(3.8);   // Resultado: 3
  ```

### 10. Módulo
- **Método**: `Math.IEEERemainder(double x, double y)`
- **Descrição**: Calcula o resto da divisão de `x` por `y`.
- **Exemplo**:
  ```csharp
  double remainder = Math.IEEERemainder(10, 3); // Resultado: 1
  ```

Esses são alguns dos métodos mais utilizados da classe `System.Math` em C#. Eles fornecem uma ampla gama de funcionalidades para cálculos matemáticos comuns e avançados.