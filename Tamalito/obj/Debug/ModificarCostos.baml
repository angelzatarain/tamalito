   M S B A M L   `   `   `  ����C  ?Tamalito, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TamalitoTamalito  5   	       Tamalito.ModificarCostos   5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5	   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5
   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Tamalito     5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	     � Title$  ModificarCostos��5   	   $	��415��6!   $	��420��6.    � WindowStyle$
 None=�6:    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6g   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��0��5      
������ ._�5      � ���	#FF455A64.+�5      �� -   5        $
��Left=�5      $��32��64   $��32��6?   $��9 0 0 0q�6K   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6\   $��0q�6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowBack=�6.   5      �� 5      $��Center=�6   $��Center=�65   $��18(�6P   ���	#DDFFFFFF$
��Bold"�6u   $��Segoe UI)�6�   .��6�   Modificar precio6�   �� 5      -   5        $��Right=�5      $��32��65   $��32��6@   $��0 0 9 0q�6L   $ Depth3=�6]   $��0q�6�   .��5        $ WindowClose=�6.   5      5!      5"      � 5$   
   $��1��6   .+�5%      �� -   5         ��Name$ lbIdProducto��5%      $��Id Producto��6*   $
��Left=�6@   $��	49,18,0,0q�6[   $	��Top=�6n   $��16(�6�   $	��107��6�   �� 5&      -   5        $ lbNombre��5&      $��Nombre��6&   $
��Left=�67   $��	49,73,0,0q�6R   $	��Top=�6e   $��84��6}   $��16(�6�   �� 5'      -   5         ��Name$ tbIdProducto��5'      $
��Left=�6,   $��42��6G   $��
180,10,0,0q�6S   	 �� TextWrapping$
	 Wrap=�6g   $	��Top=�6{   $	��160��6�   $��16(�6�   �� 5(      -   5        $ tbNombre��5(      $
��Left=�6(   $��37��6C   $��
180,65,0,0q�6O   $
	 Wrap=�6c   $	��Top=�6w   $	��160��6�   $��16(�6�   �� 5)      -   5        $ lbNuevoPrecio��5)      $��Nuevo Precio��6+   $
��Left=�6B   $��
49,243,0,0q�6]   $	��Top=�6q   $	��107��6�   $��16(�6�   �� 5*      -	   5        $ tbNuevoPrecio��5*      $
��Left=�6-   $��39��6H   $��180,233,0,0q�6T   $
	 Wrap=�6i   $	��Top=�6}   $	��160��6�   $��16(�6�   �� 5+      -
   5        
 ��Name$
 btContinuar��5+      $��	Modificar��6*   $
��Left=�6>   $��206,290,0,0q�6Y   $	��Top=�6n   $	��113��6�   $��16(�6�   $��39��6�   �� 5,      -   5        $ lbPrecioActual��5,      $��Precio Actual��6,   $
��Left=�6D   $��
49,193,0,0q�6_   $	��Top=�6s   $	��124��6�   $��16(�6�   �� 5-      -   5        $
 btConsultar��5-      $��	Consultar��6*   $
��Left=�6>   $��206,133,0,0q�6Y   $	��Top=�6n   $	��113��6�   $��16(�6�   $��39��6�   �� 5.      -   5        $ lbPrecioActual1��5.      $�� ��6-   $
��Left=�68   $��224,187,0,0q�6S   $	��Top=�6h   $	��134��6�   
���   �$��16(�6�   $��35��6�   5/      51      52      