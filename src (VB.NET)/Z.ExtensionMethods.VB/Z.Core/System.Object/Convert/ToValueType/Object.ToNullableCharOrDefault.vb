
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_391

	''' <summary>
	'''     An object extension method that converts this object to a nullable character or default.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The given data converted to a char?</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToNullableCharOrDefault(this As Object) As System.Nullable(Of Char)
		Try
			If this Is Nothing OrElse this = DBNull.Value Then
				Return Nothing
			End If

			Return Convert.ToChar(this)
		Catch generatedExceptionName As Exception
			Return ControlChars.NullChar
		End Try
	End Function

	''' <summary>
	'''     An object extension method that converts this object to a nullable character or default.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="defaultValue">The default value.</param>
	''' <returns>The given data converted to a char?</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToNullableCharOrDefault(this As Object, defaultValue As System.Nullable(Of Char)) As System.Nullable(Of Char)
		Try
			If this Is Nothing OrElse this = DBNull.Value Then
				Return Nothing
			End If

			Return Convert.ToChar(this)
		Catch generatedExceptionName As Exception
			Return defaultValue
		End Try
	End Function

	''' <summary>
	'''     An object extension method that converts this object to a nullable character or default.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>The given data converted to a char?</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToNullableCharOrDefault(this As Object, defaultValueFactory As Func(Of System.Nullable(Of Char))) As System.Nullable(Of Char)
		Try
			If this Is Nothing OrElse this = DBNull.Value Then
				Return Nothing
			End If

			Return Convert.ToChar(this)
		Catch generatedExceptionName As Exception
			Return defaultValueFactory()
		End Try
	End Function
End Module


