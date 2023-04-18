set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[TEMP_SpAnalizSabitleriSec]
(
	@kurumkodu int
)
AS
	SET NOCOUNT ON;
SELECT     ID, ORGANIKTOPRAK, ORGANIKNK, ORGANIKPOTASYUMDIKROMAT, KIRECTOPRAK, KIRECATM, KIRECSICAKLIK, FOSFORTOPRAKMIKTAR, 
                      FOSFORSEYRELTMEFAKTORU, MIKROTOPRAKMIKTARI, MIKROSEYRELTMEFATORU, MAKROTOPRAKMIKTARI, MAKRISEYRELTMEFAKTORU, PSF, 
                      KSF, NASF, MGSF, CASF, FESF, ZNSF, MNSF, CUSF, BSF, KURUMKODU, KSABITI
FROM         TBL_ANALIZSABITLERI
WHERE     (KURUMKODU = @kurumkodu)

