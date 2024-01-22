from fastapi import APIRouter, Form

router = APIRouter()

@router.get("/calculate")
async def show_calculator():
    return {"message": "Welcome to the calculator!"}

@router.post("/calculate")
async def calculate(num1: float = Form(...), num2: float = Form(...), operation: str = Form(...)):
    if operation == "+":
        result = num1 + num2
    elif operation == "-":
        result = num1 - num2
    elif operation == "*":
        result = num1 * num2
    elif operation == "/":
        result = num1 / num2
    else:
        return {"error": "Invalid operation"}

    return {"result": result}