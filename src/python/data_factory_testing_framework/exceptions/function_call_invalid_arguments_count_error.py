class FunctionCallInvalidArgumentsCountError(Exception):
    def __init__(self, name, evaluated_arguments, parameters):
        message = (
            f"FunctionCall {name} has invalid arguments count. "
            f"Evaluated arguments: \"{', '.join(map(str, evaluated_arguments))}\". "
            f"Expected argument types: {', '.join(parameters)}"
        )
        super().__init__(message)
