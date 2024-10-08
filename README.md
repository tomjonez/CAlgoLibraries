# CAlgoLibraries

A collection of reusable libraries for CAlgo.

## Libraries

### Indicators.Stochastic

The `Stochastic` library provides several helper functions to work with the Stochastic Oscillator.

#### Functions

- **`IsStochasticOverbought()`**  
  Checks if the Stochastic oscillator's PercentK value is over the defined overbought threshold.

  **Returns:**  
  `true` if the PercentK value is over the overbought value, otherwise `false`.

- **`IsStochasticOversold()`**  
  Checks if the Stochastic oscillator's PercentK value is under the defined oversold threshold.

  **Returns:**  
  `true` if the PercentK value is under the oversold value, otherwise `false`.

- **`GetPercentK(int position)`**
  Gets the PercentK value at the passed in position

  **Returns:**
  Return the Percent value