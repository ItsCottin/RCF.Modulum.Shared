using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCF.Modulum.Shared.Constants.Email
{
    public static class EmailConstants
    {
        private static string GetContent = """
			<!doctype html>
		<html lang="pt-BR">
		<head>
			<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
		</head>
		<body marginheight="0" topmargin="0" marginwidth="0" style="margin: 0px; background-color: #f2f3f8;" leftmargin="0">
			<table cellspacing="0" border="0" cellpadding="0" width="100%" bgcolor="#f2f3f8"
				style="@import url(https://fonts.googleapis.com/css?family=Rubik:300,400,500,700|Open+Sans:300,400,600,700); font-family: 'Open Sans', sans-serif;">
				<tr>
					<td>
						<table style="background-color: #f2f3f8; max-width:670px;  margin:0 auto;" width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
							<tr>
								<td style="height:80px;">&nbsp;</td>
							</tr>
							<tr>
								<td>
									<table width="95%" border="0" align="center" cellpadding="0" cellspacing="0"
										style="max-width:670px;background:#fff; border-radius:3px; text-align:center;-webkit-box-shadow:0 6px 18px 0 rgba(0,0,0,.06);-moz-box-shadow:0 6px 18px 0 rgba(0,0,0,.06);box-shadow:0 6px 18px 0 rgba(0,0,0,.06);">
										<tr>
											<td style="height:40px;">&nbsp;</td>
										</tr>
										<tr>
											<td style="padding:0 35px;">
												<h1 style="color:#1e1e2d; font-weight:500; margin:0;font-size:32px;font-family:'Rubik',sans-serif;">
													Verificação</h1>
												<span
													style="display:inline-block; vertical-align:middle; margin:29px 0 26px; border-bottom:1px solid #cecece; width:100px;"></span>
												<p style="color:#455056; font-size:15px;line-height:24px; margin:0;">
													Insira o código abaixo no sistema continuar:
												</p>

												<!-- CÓDIGO VISUAL -->
												<div style="margin-top:30px; display:flex; justify-content:center; gap:10px;">
													<span style="display:inline-block; width:40px; height:50px; font-size:24px; line-height:50px; text-align:center; background:#f0f0f0; border-radius:8px; font-weight:bold;">cod1</span>
													<span style="display:inline-block; width:40px; height:50px; font-size:24px; line-height:50px; text-align:center; background:#f0f0f0; border-radius:8px; font-weight:bold;">cod2</span>
													<span style="display:inline-block; width:40px; height:50px; font-size:24px; line-height:50px; text-align:center; background:#f0f0f0; border-radius:8px; font-weight:bold;">cod3</span>
													<span style="display:inline-block; width:40px; height:50px; font-size:24px; line-height:50px; text-align:center; background:#f0f0f0; border-radius:8px; font-weight:bold;">cod4</span>
													<span style="display:inline-block; width:40px; height:50px; font-size:24px; line-height:50px; text-align:center; background:#f0f0f0; border-radius:8px; font-weight:bold;">cod5</span>
													<span style="display:inline-block; width:40px; height:50px; font-size:24px; line-height:50px; text-align:center; background:#f0f0f0; border-radius:8px; font-weight:bold;">cod6</span>
												</div>

												<!-- MENSAGEM OPCIONAL -->
												<p style="margin-top:25px; font-size:14px; color:#777;">
													O código expira em 10 minutos.
												</p>
											</td>
										</tr>
										<tr>
											<td style="height:40px;">&nbsp;</td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td style="height:80px;">&nbsp;</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</body>
		</html>
		""";
    }
}
