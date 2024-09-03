import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import DataFetchingComponent from './DatafetchComponent'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <DataFetchingComponent />
    </>
  )
}

export default App
